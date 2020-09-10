using ClassLibrary1CoreService;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
namespace WpfApp1
{
    public class MainWindowViewModel : ReactiveObject
    {
        public ReactiveCommand<Unit, string> AddNumbers { get; }
        public MainWindowViewModel()
        {
            AddNumbers = ReactiveCommand.CreateFromTask(AddNumbersHandler);
            AddNumbers.ToPropertyEx(this, y => y.Sum);
            //AddNumbers.ThrownExceptions.Subscribe(ex => this.Log().Warn("Error!", ex));

            this.WhenAnyValue(x => x.Input1, x => x.Input2)
                .Select(_ => Unit.Default)
                .InvokeCommand(AddNumbers);
        }

        private async Task<string> AddNumbersHandler()
        {
            var sum = await ArithmeticAPIClient.AddNumbersAsync(Input1, Input2);
            
            return sum > 0 ? $"{sum}" : "";
        }

        [Reactive]public string Input1 { get; set; }
        [Reactive] public string Input2 { get; set; }
        public string Sum { [ObservableAsProperty] get; }
    }
}
using ClassLibrary1CoreService;
using ReactiveUI;
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
            AddNumbers.ToProperty(this, y => y.Sum, out _sum);

            this.WhenAnyValue(x => x.Input1, x => x.Input2,
                (a, b) => !string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
                .Select(_ => Unit.Default)
                .InvokeCommand(AddNumbers);
        }

        private async Task<string> AddNumbersHandler()
        {
            await Task.Delay(1000);

            var sum = await ArithmeticAPIClient.AddNumbersAsync(Input1, Input2);

            return sum > 0 ? $"{sum}" : "";
        }

        private string _input1;
        public string Input1
        {
            get => _input1;
            set => this.RaiseAndSetIfChanged(ref _input1, value);
        }
        private string _input2;
        public string Input2
        {
            get => _input2;
            set => this.RaiseAndSetIfChanged(ref _input2, value);
        }
        private ObservableAsPropertyHelper<string> _sum;
        public string Sum => _sum.Value;
    }
}
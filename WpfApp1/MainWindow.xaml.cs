using ReactiveUI;
using System;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += async (sender, error) =>
            {
                await Task.Delay(50);
                Input1.CaretBrush = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                Input2.CaretBrush = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            };

            ViewModel = new MainWindowViewModel();
            IDisposable disp = null;
            disp = this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                    vm => vm.Input1,
                    v => v.Input1.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.Input2,
                    v => v.Input2.Text)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel,
                    vm => vm.Sum,
                    v => v.Sum.Text)
                    .DisposeWith(disposables);
                disp.DisposeWith(disposables);
            });
        }
    }
}
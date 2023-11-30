using System.Reactive;
using ReactiveUI;

namespace MagicButton.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit, Unit> SwitchPercentageCommand { get; }

        private double _percentage;
        public double Percentage
        {
            get => _percentage;
            set
            {
                this.RaiseAndSetIfChanged(ref _percentage, value);
                System.Diagnostics.Debug.WriteLine($"Percentage: {Percentage}");
            }
        }

        public MainWindowViewModel()
        {
            SwitchPercentageCommand = ReactiveCommand.Create(SwitchPercentage);
            Percentage = 0.9; // init value works!
        }

        private void SwitchPercentage()
        {
            Percentage = (Percentage * 100 + 10) % 100 / 100;
        }
    }
}
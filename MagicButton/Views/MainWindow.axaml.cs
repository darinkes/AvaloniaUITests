using Avalonia.Controls;
using MagicButton.ViewModels;

namespace MagicButton.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
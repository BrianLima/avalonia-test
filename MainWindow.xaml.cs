using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace avalonia_test
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
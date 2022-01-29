using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MLNetworkMonitor.Pages
{
    public class StartPage : UserControl
    {
        public StartPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

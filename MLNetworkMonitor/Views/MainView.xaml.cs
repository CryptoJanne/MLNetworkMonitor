using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MLNetworkMonitor.Views
{
    public class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);            
        }
    }
}

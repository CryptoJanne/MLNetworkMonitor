using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MLNetworkMonitor.Pages
{
    public class StartPage : UserControl
    {
        public string asdf = "asdffffffff";
        public StartPage()
        {
            this.InitializeComponent();
            var textblock = this.FindControl<TextBlock>("Test");
            textblock.Text = "YOU THINK U FOUND ME???";
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

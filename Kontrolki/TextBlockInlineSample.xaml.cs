using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;

namespace SpeechRecognition.Kontrolki
{
    /// <summary>
    /// Interaction logic for TextBlockInlineSample.xaml
    /// </summary>
    public partial class TextBlockInlineSample : Window
    {
        public TextBlockInlineSample()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);
        }
    }
}

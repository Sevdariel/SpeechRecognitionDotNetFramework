using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SpeechRecognition
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            ResourceSample rsw = new ResourceSample();
            ExtendedResourceSample ersw = new ExtendedResourceSample();
            ResourcesFromCodeBehindSample rfcbsw = new ResourcesFromCodeBehindSample();
            if (e.Args.Length == 1)
                MessageBox.Show("Now opening file: \n\n" + e.Args[0]);
            //rsw.Show();
            //ersw.Show();
            rfcbsw.Show();
        }
    }
}

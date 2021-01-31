using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace SpeechRecognition.Kontrolki
{
    /// <summary>
    /// Interaction logic for ImageControlCodeBehindSample.xaml
    /// </summary>
    public partial class ImageControlCodeBehindSample : Window
    {
        public ImageControlCodeBehindSample()
        {
            InitializeComponent();
        }

        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                imgDynamic.Source = new BitmapImage(fileUri);
            }
        }
        private void BtnLoadFromResource_Click(object sender, RoutedEventArgs e)
        {
            Uri resourceUri = new Uri("/Images/google.png", UriKind.Relative);
            imgDynamic.Source = new BitmapImage(resourceUri);
        }
    }
}

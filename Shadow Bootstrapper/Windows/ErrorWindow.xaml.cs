using Shadow_Bootstrapper.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Shadow_Bootstrapper.Windows
{
    /// <summary>
    /// Interaction logic for ErrorWindow.xaml
    /// </summary>
    public partial class ErrorWindow : Window
    {
        public ErrorWindow()
        {
            InitializeComponent();
            Opacity = 0;
        }

        private async void OnLoad(object sender, RoutedEventArgs e)
        {
            Animation.Fade(this, 0, 1, 1, Ease.quarticEase);
            await Task.Delay(3000);
            Animation.Fade(this, 1, 0, 1, Ease.quarticEase);
            await Task.Delay(1000);
            Close();
        }
    }
}

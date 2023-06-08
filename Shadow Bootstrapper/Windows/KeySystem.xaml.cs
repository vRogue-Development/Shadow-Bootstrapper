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
using Shadow_Bootstrapper.Classes;

namespace Shadow_Bootstrapper.Windows
{
    /// <summary>
    /// Interaction logic for KeySystem.xaml
    /// </summary>
    public partial class KeySystem : Window
    {
        public KeySystem()
        {
            InitializeComponent();
            foreach (DependencyObject Object in ChildrenGrid.Children)
            {
                Object.SetValue(OpacityProperty, 0.0);
            }
        }

        private async void OnLoad(object sender, RoutedEventArgs e)
        {
            await Task.Delay(500);
            foreach (DependencyObject Object in ChildrenGrid.Children)
            {
                await Task.Delay(100);
                Animation.Fade(Object, 0, 1, 1, Ease.quarticEase);
            }
        }

        private void MouseDownHandler(object sender, MouseButtonEventArgs e)
        {
            switch (((FrameworkElement)sender).Name)
            {
                case "Border1":
                    DragMove();
                    break;
            }
        }

        private async void ButtonHandler(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "Enter":
                    Animation.Fade(this, 1, 0, 1, Ease.quarticEase);
                    await Task.Delay(1000);
                    new ErrorWindow().Show();
                    await Task.Delay(4000);
                    Animation.Fade(this, 0, 1, 1, Ease.quarticEase);
                    break;
                case "GetKey":
                    break;
            }
        }
    }
}

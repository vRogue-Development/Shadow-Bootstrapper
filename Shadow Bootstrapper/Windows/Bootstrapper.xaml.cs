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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using Shadow_Bootstrapper.Classes;

namespace Shadow_Bootstrapper.Windows
{
    /// <summary>
    /// Interaction logic for Bootstrapper.xaml
    /// </summary>
    public partial class Bootstrapper : Window
    {
        public Bootstrapper()
        {
            InitializeComponent();

            #region Margins/Opacity
            MainGrid.Margin = new Thickness(0, 0, 0, 350);
            BigLogo.Margin = new Thickness(120, 205, 130, 125);
            Border1.Margin = new Thickness(-6, -23, 275, 0);
            Border2.Margin = new Thickness(-13, 60, 282, 0);
            Border3.Margin = new Thickness(288, 80, -20, 0);
            DownloadLabel.Margin = new Thickness(-1, 277, 270, 34);
            CopyrightLabel.Margin = new Thickness(-1, 309, 270, 14);
            BigLogo.Opacity = 0;
            SmallLogo.Opacity = 0;
            TitleLabel.Opacity = 0;
            SloganLogo.Opacity = 0;
            #endregion
        }

        private async void OnLoad(object sender, RoutedEventArgs e)
        {
            #region Animations
            await Task.Delay(1000);
            Animation.Fade(MainGrid, 0, 1, 1, Ease.quinticEase);
            Animation.Shift(MainGrid, MainGrid.Margin, new Thickness(), 1, Ease.quinticEase);
            await Task.Delay(900);
            Animation.Fade(BigLogo, 0, .5, 1, Ease.quarticEase);
            Animation.Shift(BigLogo, BigLogo.Margin, new Thickness(20, 90, 25, 40), 1, Ease.quarticEase);
            await Task.Delay(900);
            Animation.Fade(BigLogo, .5, .1, 1, Ease.quinticEase);
            Animation.Fade(Border1, 0, 1, 1, Ease.quarticEase);
            Animation.Shift(Border1, Border1.Margin, new Thickness(-5, -15, -5, 0), 1, Ease.quarticEase);
            await Task.Delay(200);
            Animation.Fade(Border2, 0, 1, 1, Ease.quarticEase);
            Animation.Shift(Border2, Border2.Margin, new Thickness(-15, 38, 57, 0), 1, Ease.quarticEase);
            await Task.Delay(200);
            Animation.Fade(Border3, 0, 1, 1, Ease.quarticEase);
            Animation.Shift(Border3, Border3.Margin, new Thickness(121, 64, -20, 0), 1, Ease.quarticEase);
            await Task.Delay(500);
            Animation.Fade(SmallLogo, 0, .6, 1, Ease.quinticEase);
            await Task.Delay(200);
            Animation.Fade(TitleLabel, 0, 1, 1, Ease.quinticEase);
            await Task.Delay(200);
            Animation.Fade(SloganLogo, 0, 1, 1, Ease.quinticEase);
            await Task.Delay(500);
            Animation.Fade(DownloadLabel, 0, 1, 1, Ease.quinticEase);
            Animation.Shift(DownloadLabel, DownloadLabel.Margin, new Thickness(0, 277, 45, 34), 1, Ease.quarticEase);
            await Task.Delay(200);
            Animation.Fade(CopyrightLabel, 0, 1, 1, Ease.quinticEase);
            Animation.Shift(CopyrightLabel, CopyrightLabel.Margin, new Thickness(-1, 309, 141, 14), 1, Ease.quarticEase);
            await Task.Delay(1000);
            DispatcherTimer timer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 0, 0, 1) };
            timer.Tick += delegate
            {
                if (ProgressBar.Value != 100)
                    ProgressBar.Value += 1;
                else
                    timer.Stop();
            };
            timer.Start();
            #endregion

            #region EndAnimations
            await Task.Delay(1500);
            Animation.Fade(DownloadLabel, 1, 0, 1, Ease.quinticEase);
            await Task.Delay(100);
            Animation.Fade(ProgressBar, 1, 0, 1, Ease.quarticEase);
            await Task.Delay(1000);
            Animation.Shift(CopyrightLabel, CopyrightLabel.Margin, new Thickness(-1, 329, 141, -6), .5, Ease.quarticEase);
            await Task.Delay(500);
            new KeySystem().Show();
            await Task.Delay(500);
            Hide();
            #endregion
        }
    }
}

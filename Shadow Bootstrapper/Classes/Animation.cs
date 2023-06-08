using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

public static class Animation
{
    #region Animation Voids
    public static void Shift(DependencyObject Object, Thickness From, Thickness To, double Time, IEasingFunction Ease)
    {
        ThicknessAnimation animation = new ThicknessAnimation()
        {
            Duration = TimeSpan.FromSeconds(Time),
            From = From,
            EasingFunction = Ease,
            To = To,
        };
        Storyboard.SetTarget(animation, Object);
        Storyboard.SetTargetProperty(animation, new PropertyPath("(Panel.Margin)"));
        Storyboard storyboard = new Storyboard();
        storyboard.Children.Add(animation);
        storyboard.Begin();
    }

    public static void Fade(DependencyObject Object, double From, double To, double Time, IEasingFunction Ease)
    {
        DoubleAnimation animation = new DoubleAnimation()
        {
            Duration = TimeSpan.FromSeconds(Time),
            From = From,
            EasingFunction = Ease,
            To = To,
        };
        Storyboard.SetTarget(animation, Object);
        Storyboard.SetTargetProperty(animation, new PropertyPath("(Panel.Opacity)"));
        Storyboard storyboard = new Storyboard();
        storyboard.Children.Add(animation);
        storyboard.Begin();
    }
    #endregion
}


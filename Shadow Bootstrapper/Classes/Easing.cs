using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Shadow_Bootstrapper.Classes
{
    class Ease
    {
        public static IEasingFunction quinticEase = new QuinticEase { EasingMode = EasingMode.EaseInOut };
        public static IEasingFunction bounceEase = new BounceEase { EasingMode = EasingMode.EaseOut, Bounciness = 2, Bounces = 5 };
        public static IEasingFunction quarticEase = new QuarticEase { EasingMode = EasingMode.EaseInOut };
    }
}

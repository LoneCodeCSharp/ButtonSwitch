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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ButtonSwitch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GradientStopCollection gsc = new GradientStopCollection();
        public GradientStopCollection gsc2 = new GradientStopCollection();
        public MainWindow()
        {
            InitializeComponent(); 
       
            gsc.Add(new GradientStop()
            {
                Color = Color.FromRgb(225,61,255),
                Offset = 0.4
            });
            gsc.Add(new GradientStop()
            {
                Color = Color.FromRgb(254, 64, 160),
                Offset = 0.6
            });
            gsc2.Add(new GradientStop()
            {
                Color = Color.FromRgb(37, 247, 121),
                Offset = 0.4
            });
            gsc2.Add(new GradientStop()
            {
                Color = Color.FromRgb(37, 247, 180),
                Offset = 0.6
            });
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            if (btn1.Margin.Left == -130)
            {
                ThicknessAnimationUsingKeyFrames th = new ThicknessAnimationUsingKeyFrames();
                KeyTime keyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
                Thickness thickness1 = new Thickness(0, 0, 0, 0);
                KeyTime keyTime2 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.25));
                Thickness thickness2 = new Thickness(130, 0, 0, 0);
                th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness1, keyTime1));
                th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness2, keyTime2));
                btn1.BeginAnimation(MarginProperty, th);
                gradientBorder.Background = new LinearGradientBrush(gsc)
                {
                    StartPoint = new Point(0,1),
                    EndPoint = new Point(1, 1)
                };
                gradientBorder.Effect = new DropShadowEffect()
                {
                    BlurRadius = 20,
                    Color = Color.FromRgb(225, 61, 255),
                    Direction = 0,
                    Opacity = 1,
                    RenderingBias = RenderingBias.Quality,
                    ShadowDepth = 1


                };
            }
            else
            {
                ThicknessAnimationUsingKeyFrames th = new ThicknessAnimationUsingKeyFrames();
                KeyTime keyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
                Thickness thickness1 = new Thickness(130, 0, 0, 0);
                KeyTime keyTime2 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.25));
                Thickness thickness2 = new Thickness(-130, 0, 0, 0);
                th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness1, keyTime1));
                th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness2, keyTime2));
                btn1.BeginAnimation(MarginProperty, th);
                gradientBorder.Background = new SolidColorBrush(Color.FromRgb(35,35,35));
                gradientBorder.Effect = null;
            }
            

        }

        private void btn2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (btn2.Margin.Left == -130)
            {
                ThicknessAnimationUsingKeyFrames th = new ThicknessAnimationUsingKeyFrames();
                KeyTime keyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
                Thickness thickness1 = new Thickness(0, 0, 0, 0);
                KeyTime keyTime2 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.25));
                Thickness thickness2 = new Thickness(130, 0, 0, 0);
                th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness1, keyTime1));
                th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness2, keyTime2));
                btn2.BeginAnimation(MarginProperty, th);
                gradientBorder2.Background = new LinearGradientBrush(gsc2)
                {
                    StartPoint = new Point(0, 1),
                    EndPoint = new Point(1, 1)
                };
                gradientBorder2.Effect = new DropShadowEffect()
                {
                    BlurRadius = 20,
                    Color = Color.FromRgb(37, 247, 180),
                    Direction = 0,
                    Opacity = 1,
                    RenderingBias = RenderingBias.Quality,
                    ShadowDepth = 1


                };
            }
            else
            {
                ThicknessAnimationUsingKeyFrames th = new ThicknessAnimationUsingKeyFrames();
                KeyTime keyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
                Thickness thickness1 = new Thickness(130, 0, 0, 0);
                KeyTime keyTime2 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.25));
                Thickness thickness2 = new Thickness(-130, 0, 0, 0);
                th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness1, keyTime1));
                th.KeyFrames.Add(new SplineThicknessKeyFrame(thickness2, keyTime2));
                btn2.BeginAnimation(MarginProperty, th);
                gradientBorder2.Background = new SolidColorBrush(Color.FromRgb(35, 35, 35));
                gradientBorder2.Effect = null;
            }

        }
    }
}

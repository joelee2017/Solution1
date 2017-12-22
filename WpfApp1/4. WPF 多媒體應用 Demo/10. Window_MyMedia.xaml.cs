
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window_MyMedia : Window
    {
        public Window_MyMedia()
        {
            InitializeComponent();
            mediaElement1.LoadedBehavior = MediaState.Manual;

        }
        private void Play_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaElement1.Play();
        }
         private void Pause_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaElement1.Pause();
        }

         private void Stop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaElement1.Stop();
        }

          private void mediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            //        'Volume
                   Slider1.Value = mediaElement1.Volume;

            //        'Position
                   Slider2.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds;
        }
          private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs< Double> e)
        {
            mediaElement1.Volume = Slider1.Value;
        }

          private void Slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<Double> e)
          {
              mediaElement1.Position = new TimeSpan(0, 0, 0, 0, (int)Slider2.Value);

          }

          private void Play_ImageFailed(object sender, ExceptionRoutedEventArgs e)
          {

          }
    }
}



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
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window_WPF_影像播放與畫面處理 : Window
    {
        Storyboard sb; 

        public Window_WPF_影像播放與畫面處理()
        {
            InitializeComponent();
                    //'=========================================改成 LoadedBehavior= manual     Me.mediaElement1.Play()
                    //'Way 1:
                    sb = (Storyboard)this.Resources["Storyboard_1"];
                    sb.Begin();


                    //'Way 2
                    //this.mediaElement1.LoadedBehavior = MediaState.Manual
                   //this.mediaElement1.Volume = volumeSlider.Value

        }

        private void MediaTimeline_CurrentTimeInvalidated(object sender,EventArgs e)
        {
            timelineSlider.Value = mediaElement1.Position.TotalMilliseconds;
        }



        private void mediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            timelineSlider.Value = mediaElement1.Position.TotalMilliseconds;

                    timelineSlider.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds;

                    //'Me.clip.Center = New Point(Me.mediaElement1.ActualWidth / 2, Me.mediaElement1.ActualHeight / 2)
                    //'Me.clip.RadiusX = Me.mediaElement1.ActualWidth / 2
                    //'Me.clip.RadiusY = Me.mediaElement1.ActualHeight / 2
        }
    }
}

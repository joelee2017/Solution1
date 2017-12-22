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
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WpfApplication1._4._WPF_應用_Demo
{
    /// <summary>
    /// Window_2D_動畫_Transorm_使用程式碼控制動畫運行.xaml 的互動邏輯
    /// </summary>
    public partial class Window_使用程式碼控制動畫運行 : Window
    {
        private Storyboard sb;

        public Window_使用程式碼控制動畫運行()
        {
            InitializeComponent();
            sb = (Storyboard)Grid1.Resources["sb1"];
        }
        private void StackPanel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            switch (((FrameworkElement)e.Source).Name)
            {
                case "Play":
                    sb.Begin();
                    break;
                case "Stop":
                    sb.Stop();
                    break;
                case "Pause":
                    sb.Pause();
                    break;
                case "Resume":
                    sb.Resume();
                    break;
                case "Next":
                    sb.SpeedRatio += 1;
                    sb.SetSpeedRatio(sb.SpeedRatio);
                    break;
                case "Prev":
                    sb.SpeedRatio -= 1;
                    sb.SetSpeedRatio(sb.SpeedRatio);
                    break;
            }
        }


    }
}

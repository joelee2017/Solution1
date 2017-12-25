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

namespace WpfApp1._4_1.WPF應用
{
    /// <summary>
    /// Window_MyScreenSaver.xaml 的互動邏輯
    /// </summary>
    public partial class Window_MyScreenSaver : Window
    {
        public Window_MyScreenSaver()
        {
            InitializeComponent();

            // 整合至 System.Windows.Threading.Dispatcher 佇列中的計時器，會在指定的時間間隔以指定的優先權處理這個佇列。
            DispatcherTimer timer1 = new DispatcherTimer();
            timer1.IsEnabled = true; //啟動時間器
            timer1.Interval = new TimeSpan(0, 0, 0, 0, 100);//100 零點一秒更新一次
            timer1.Tick += Timer1_Tick;

            this.Loaded += Window_MyScreenSaver_Loaded;
        }

        private void Window_MyScreenSaver_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard sb1 = (Storyboard)this.Resources["sb1"];
            Storyboard sb2 = (Storyboard)this.Resources["sb2"];
           // sb1.Begin();
            sb2.Begin();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //取得UtcNow 國際標準時間，轉換成完成時間。
            this.TextBlock3.Text = DateTime.UtcNow.ToLongTimeString();
            //屬性寫法
            //this.TextBlock1.Margin = new Thickness(this.TextBlock1.Margin.Left + 20, this.TextBlock1.Margin.Top, 0, 0);
            this.myTranslatex.X +=50;
            if(this.myTranslatex.X>this.Width)
            {
                this.myTranslatex.X = 0;
            }
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}

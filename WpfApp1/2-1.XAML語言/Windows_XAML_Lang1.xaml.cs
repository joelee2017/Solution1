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

namespace WpfApp1
{
    /// <summary>
    /// Windows_XAML_Lang1.xaml 的互動邏輯
    /// </summary>
    public partial class Windows_XAML_Lang1 : Window
    {
        public Windows_XAML_Lang1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 網頁內容也可以用程式碼直接寫，但過於麻煩
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button x = new Button();
            x.Content = "Hello";
            x.Background = new SolidColorBrush(Colors.Orange);

            this.Grid1.Children.Add(x);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush brush1 = new LinearGradientBrush();
            brush1.StartPoint = new Point(0, 0);
            brush1.EndPoint = new Point(1, 1);

            brush1.GradientStops.Add(new GradientStop(Colors.Red, 0));
            brush1.GradientStops.Add(new GradientStop(Colors.Orange, 0.5));
            brush1.GradientStops.Add(new GradientStop(Colors.Orchid, 0.7));
            brush1.GradientStops.Add(new GradientStop(Colors.PaleGreen, 1));

            this.button1.Background = brush1;
            this.button2.Background = brush1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.button3.Background = SystemColors.ActiveCaptionBrush;
        }
    }
}

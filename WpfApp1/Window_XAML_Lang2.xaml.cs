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
    /// Window_XAML_Lang2.xaml 的互動邏輯
    /// </summary>
    public partial class Window_XAML_Lang2 : Window
    {
        public Window_XAML_Lang2()
        {
            InitializeComponent();

            //this.PreviewMouseDown += Window_XAML_Lang2_PreviewMouseDown;
            //this.Grid01.PreviewMouseDown += Grid01_PreviewMouseDown;
            //this.button03.PreviewMouseDown += Button03_PreviewMouseDown;

        }

        

        /// <summary>
        /// 事件呼叫順序 
        /// preview event 由上而下
        /// non preview event 由下而上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button03_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Button03事件");
        }

        private void Grid01_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Grid01事件");
        }

        private void Window_XAML_Lang2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Window_XAML_Lang2事件");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid.SetRow(this.button01, 1);
            Grid.SetColumn(this.button01, 1);

            Canvas.SetLeft(this.button02, 0);
            Canvas.SetTop(this.button02, 0);
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source == GdYes)
            {
                MessageBox.Show("Yes");
            }
            else 
            {
                MessageBox.Show("No");
            }
        }

        private void Grid01_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image img = e.Source as Image;
            this.Grid01.Background = new ImageBrush(img.Source);
        }
    }
}

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

namespace WpfApp1._4_1.WPF應用
{
    /// <summary>
    /// Window_XXXBruch.xaml 的互動邏輯
    /// </summary>
    public partial class Window_XXXBruch : Window
    {
        public Window_XXXBruch()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//Bding聯綁資料
        {
            VisualBrush brush1 = new VisualBrush();
            brush1.Visual = this.TestBox1;

            this.rect1.Fill = brush1;
        }
    }
}

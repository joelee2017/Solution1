
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
    public partial class Window_2D_動畫_使用_Path_2 : Window
    {
        public Window_2D_動畫_使用_Path_2()
        {
            InitializeComponent();
        }
        private void Window_MyClock_Loaded(object sender, RoutedEventArgs e)
        {

            
            ((Storyboard)this.FindResource("sb1")).Begin(this, true);


        }

    }
}


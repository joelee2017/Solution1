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

namespace WpfApp1._3_1.WPF_ControlsUI
{
    /// <summary>
    /// Window_WPFControls_2.xaml 的互動邏輯
    /// </summary>
    public partial class Window_WPFControls_2 : Window
    {
        public Window_WPFControls_2()
        {
            InitializeComponent();
        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var x =this.listbox1.SelectedItem as ListBoxItem;//將listbox1 選到的項目轉型

            if (x == null) return;

            this.Grid1.Background = x.Background;

        }

        private void stackpanel_Click(object sender, RoutedEventArgs e)
        {
            this.stackpanel.Orientation = 
            this.stackpanel.Orientation == Orientation.Horizontal ? 
                                        Orientation.Vertical : Orientation.Horizontal;
        }
    }
}

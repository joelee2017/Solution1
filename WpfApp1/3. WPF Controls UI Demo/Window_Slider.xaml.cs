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

namespace Demo._3._WPF_Control.Control_Demo
{
    /// <summary>
    /// Window_Slider.xaml 的互動邏輯
    /// </summary>
    public partial class Window_Slider : Window
    {
        public Window_Slider()
        {
            InitializeComponent();
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color c = new Color();
             c.R = (byte) this.slider1.Value;
            c.G = (byte)this.slider2.Value;
            c.B = (byte)this.slider3.Value;
            c.A = (byte)this.slider4.Value;

            this.textBox1.Text = c.R.ToString();
            this.textBox2.Text = c.G.ToString();
            this.textBox3.Text = c.B.ToString();

            this.Background = new SolidColorBrush(c);
        }
    }
}

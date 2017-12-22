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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1._3_1.WPF_ControlsUI
{
    /// <summary>
    /// UserControl_Page.xaml 的互動邏輯
    /// </summary>
    public partial class UserControl_Page : UserControl
    {
        public UserControl_Page()
        {
            InitializeComponent();
        }

        public string Desc
        {
            set { this.Label1.Content = value; }
        }

        public string ImageURL
        {
            set
            {

                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri(value, UriKind.Absolute);
                bi3.EndInit();

                this.Image1.Stretch = Stretch.Fill;
                this.Image1.Source = bi3;
            }
        }


        public byte[] Imagebyte
        {
            set
            {

                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                bi3.StreamSource = ms;
                bi3.EndInit();
                
                this.Image1.Stretch = Stretch.Fill;
                this.Image1.Source = bi3;
            }
        }
    }
}

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

namespace WpfApp_HW
{
    /// <summary>
    /// UserControl_Page.xaml 的互動邏輯
    /// </summary>
    public partial class UserControl_Page : UserControl
    {
        private object uriKind;

        public UserControl_Page()
        {
            InitializeComponent();
        }

        public string Desc
        {
            set { this.label.Content = value; }
        }

        public ImageSource ImageSource
        {
            get
            {
                return this.Image1.Source;
            }
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

        public string Id
        {
            get;
            set;
        }

        public delegate void MyEventHandler(object sender, bool? IsFavor);//事件
        public event MyEventHandler NotifyMyFavor;

        
        private void CheckBox1_Checked_1(object sender, RoutedEventArgs e)//選取
        {
            if(this.NotifyMyFavor !=null)
            {
                this.NotifyMyFavor(this, this.CheckBox1.IsChecked);
            }
        }

        private void CheckBox1_Unchecked(object sender, RoutedEventArgs e)//未選取
        {
            if(this.NotifyMyFavor !=null)
            {
                this.NotifyMyFavor(this, this.CheckBox1.IsChecked);
            }
        }
    }
}

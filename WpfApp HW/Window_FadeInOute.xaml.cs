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

namespace WpfApp_HW
{
    /// <summary>
    /// Window_FadeInOute.xaml 的互動邏輯
    /// </summary>
    public partial class Window_FadeInOute : Window
    {
        public Window_FadeInOute()
        {
            InitializeComponent();

            this.Loaded += Window_FadeInOute_Loaded;
            this.Closing += Window_FadeInOute_Closing;
        }

        private void Window_FadeInOute_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; //取消關閉程式

            Storyboard fadeOut = (Storyboard)this.Resources["fadeOut"];
            fadeOut.Completed += FadeOut_Completed;
            fadeOut.Begin();
        }

        private void FadeOut_Completed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();//關閉應用程式
            MessageBox.Show("淡出")
        }

        private void Window_FadeInOute_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard SB1 = (Storyboard)this.Resources["fadeIn"];
            SB1.Completed += SB1_Completed;
            SB1.Begin();
        }

        private void SB1_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("淡入");
        }
    }
}


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
using System;

namespace WpfApplication1
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window_Clock_Canvas : Window
    {
        public Window_Clock_Canvas()
        {
            InitializeComponent();
            //        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。
                    //'sb1.Seek(Me, DateTime.Now.TimeOfDay, TimeSeekOrigin.BeginTime)
                    //'sb2.Seek(Me, DateTime.Now.TimeOfDay, TimeSeekOrigin.BeginTime)
                    //'sb3.Seek(Me, DateTime.Now.TimeOfDay, TimeSeekOrigin.BeginTime)

                    ((Storyboard)Grid1.Resources["sb1"]).Begin(this, true);
                    ((Storyboard)Grid1.Resources["sb1"]).Seek(this, DateTime.Now.TimeOfDay, TimeSeekOrigin.BeginTime);



        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1._4_1.WPF應用
{
    /// <summary>
    /// Window_MyClock.xaml 的互動邏輯
    /// </summary>
    public partial class Window_MyClock : Window
    {
        public Window_MyClock()
        {
            InitializeComponent();

            //System.Timers.Timer timer = new System.Timers.Timer(1000);

            //    InitializeComponent();
            //    DateTime date = DateTime.Now;
            //    timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            //    timer.Enabled = true;

            ((Storyboard)grid1.Resources["sb1"]).Begin(this,true);
            ((Storyboard)grid1.Resources["sb1"]).Seek(this, DateTime.Now.TimeOfDay, TimeSeekOrigin.BeginTime);
        }

    }
}

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

namespace WpfApplication1
{
    /// <summary>
    /// Digit_Clock_2.xaml 的互動邏輯
    /// </summary>
    public partial class Digit_Clock_2 : Window
    {
        public Digit_Clock_2()
        {
            InitializeComponent();
            this.StartTimer(null, null);
        }

        //http://blogs.msdn.com/silverlight_sdk/archive/2008/03/27/make-a-silverlight-timer-silverlight-2.aspx
        public void StartTimer(object o, RoutedEventArgs sender)
        {
            System.Windows.Threading.DispatcherTimer myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000); // 100 Milliseconds
            myDispatcherTimer.Tick += new EventHandler(Each_Tick);
            myDispatcherTimer.Start();
        }

        // Fires every 1000 miliseconds while the DispatcherTimer is active.
        public void Each_Tick(object o, EventArgs sender)
        {
            hourText.Text = twoDigit(DateTime.Now.Hour.ToString());
            minuteText.Text = twoDigit(DateTime.Now.Minute.ToString());
            secondText.Text = twoDigit(DateTime.Now.Second.ToString());

            hourText1.Text = twoDigit(DateTime.Now.Hour.ToString());
            minuteText1.Text = twoDigit(DateTime.Now.Minute.ToString());
            secondText1.Text = twoDigit(DateTime.Now.Second.ToString());
        }

        string twoDigit(string input)
        {
            if (input.Length < 2)
                return "0" + input;
            else
                return input;
        }
    }
}

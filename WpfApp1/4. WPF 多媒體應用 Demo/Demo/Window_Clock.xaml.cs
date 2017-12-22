﻿
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
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window_Clock: Window
    {
        public Window_Clock()
        {
            InitializeComponent();
        }


        private DispatcherTimer _dayTimer;

        private void Window_Clock_Loaded(object sender, RoutedEventArgs e)
        {
            //' set the datacontext to be today's date
            DateTime now = DateTime.Now;
            DataContext = now.Day.ToString();

            //' then set up a timer to fire at the start of tomorrow, so that we can update
            //' the datacontext
            _dayTimer = new DispatcherTimer();
            _dayTimer.Interval = new TimeSpan(1, 0, 0, 0) - now.TimeOfDay;
            _dayTimer.Tick += new EventHandler(OnDayChange);
            _dayTimer.Start();

            //' finally, seek the timeline, which assumes a beginning at midnight, to the appropriate
            //' offset
            Storyboard sb = (Storyboard)PodClock.FindResource("sb");

            sb.Begin(PodClock, HandoffBehavior.SnapshotAndReplace, true);

            //' Seek (skip to) now.TimeOfDay into the Storboard's active period (Duration). 

            sb.Seek(PodClock, now.TimeOfDay, TimeSeekOrigin.BeginTime);
        }


        private void OnDayChange(object sender, EventArgs e)
        {
            // ' date has changed, update the datacontext to reflect today's date
            DateTime now = DateTime.Now;
            DataContext = now.Day.ToString();
            _dayTimer.Interval = new TimeSpan(1, 0, 0, 0);
        }


    }
}


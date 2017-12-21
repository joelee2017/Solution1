using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1._3_1.WPF_ControlsUI;

namespace WpfApp1
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        //public App()
        //{
        //    this.Startup += App_Startup;
        //}

        //private void App_Startup(object sender, StartupEventArgs e)
        //{
        //    this.ShutdownMode = ShutdownMode.OnLastWindowClose;//關閉事件

        //    Window w = new MainWindow();//啟動事件
        //    w.Show();            
        //}


        /// <summary>
        ///  this.ShutdownMode = ShutdownMode.OnLastWindowClose
        ///  最後一個視窗關閉才真正關閉程式
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)//覆寫原來的方法
        {
            this.ShutdownMode = ShutdownMode.OnLastWindowClose;//關閉事件

            //創建父類別  一個新的視窗
            //Window w = new Window_XAML_Lang2();//啟動事件
            Window w = new Window_WPFControls_2();//啟動事件
            w.Show();
        }
    }
}

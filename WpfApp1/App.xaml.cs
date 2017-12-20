using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

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

        protected override void OnStartup(StartupEventArgs e)//覆寫原來的方法
        {
            this.ShutdownMode = ShutdownMode.OnLastWindowClose;//關閉事件

            Window w = new MainWindow();//啟動事件
            w.Show();
        }
    }
}

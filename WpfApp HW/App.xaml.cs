using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WindowsFormsApp1;
using WpfApp_HW;
using WpfApp1;
using WpfApp1._4_1.WPF應用;

namespace WpfApp_HW
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {


            //Window c = new Window_MyNotePad_Command();
            //Window b = new MainWindow();
            //FormPhotoHW s = new FormPhotoHW();
            //Window g = new Window_MyClock();
            //Window f = new Window_MyBook();
            Window p = new Window_FadeInOute();
            //f.Show();
            //c.Show();
            //b.Show();
            //s.Show();
            //g.Show();
            p.Show();
        }
    }
}

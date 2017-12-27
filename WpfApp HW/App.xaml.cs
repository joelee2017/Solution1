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
            Window c = new Window();

             //c = new Window_MyNotePad_Command();
             //c = new MainWindow();
             //c = new FormPhotoHW();
             //c = new Window_MyClock();
             //c = new Window_MyBook();
             c = new Window_FadeInOute();

                c.Show();
        }
    }
}

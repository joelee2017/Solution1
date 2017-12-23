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

namespace WpfApp_HW
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {


            Window f = new Window_MyNotePad_Command();
            //Window f = new MainWindow();
            //Form1 f = new Form1();
            //FormPhotoHW f = new FormPhotoHW();
            f.Show();
        }
    }
}

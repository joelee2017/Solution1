using Demo;
using Demo._3._WPF_Control.Control_Demo;
using Magnify;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UsingVisualBrush;
using WpfApp1._3_1.WPF_ControlsUI;
using WpfApp1._4_1.WPF應用;
using WpfApplication__MyHomework_.TestControl;
using WpfApplication1;

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
            //Window w = new Window_WPFControls_2();//啟動事件
            //Window w = new Window_MyBook();//啟動事件
            //Window w = new Window_MetroUI();//啟動事件
            //Window w = new Window_Lrregular();//啟動事件
            //Window w = new Window_Lrregular2();//啟動事件
            //Window w = new Window_TextBlock();
            //Window w = new Window_Slider();
            //Window w=new  Window_ViewBox();
            //Window w = new Window_XXXBruch();
            //Window w = new Window_VisualBrush();
            //Window w = new Window_InkCanvasSave_VisualBrush();
            //Window w =new Window_ReflectionExample_VisualBrush();
            //Window w = new Window_放大鏡();
            //Window w = new Window_2D();
            //Window w = new Window_Transorm();
            //Window w = new UserControl_MyClock();
            //Window w = new Window_MyClock_Calendar();
            //Window w = new Window_2D動畫_Opacity_Color_Width();
            //Window w = new Window_MyScreenSaver();
            //Window w = new Window_FadeInOute();
            //Window w = new Window_Clock_Canvas();
            //Window w = new Window_Resources_1();
            //Window w = new Window_Resources_2();
            Window w = new Window_Binding();
            w.Show();
        }
    }
}

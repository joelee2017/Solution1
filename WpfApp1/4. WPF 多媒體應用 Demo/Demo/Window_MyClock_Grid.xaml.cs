

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
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window_MyClock_Grid : Window
    {
        public Window_MyClock_Grid()
        {
            InitializeComponent();
                    //' 在 InitializeComponent() 呼叫之後加入任何初始設定。
                  ((Storyboard )Grid1.Resources["storyBoard1"]).Begin(this, true);


                    //'在到達下個時鐘刻度時，搜尋這個 Storyboard 直到新位置
                    //'instance.Seek(containingObject, offset, origin)

                    //'        ()
                    //'offset :型別：System..::.TimeSpan

                    //'offset: 正值或負值，描述時刻表應該從指定的 origin 向前移動或向後移動的數量。


                   ((Storyboard)Grid1.Resources["storyBoard1"]).Seek(this, DateTime.Now.TimeOfDay, TimeSeekOrigin.BeginTime);

                System.Windows.Threading.DispatcherTimer     timer1 = new System.Windows.Threading.DispatcherTimer();
                    timer1.Tick +=new EventHandler(timer1_Tick); 

                    timer1.Start();


        }

        void timer1_Tick(object sender, EventArgs e)
        {
this.textBlock1.Text = DateTime.Now.ToLongTimeString();

        }
   

    }
}


//Imports System.Windows.Media.Animation

//Partial Public Class Window_MyClock_Grid

//    Public Sub New()

//        ' 此為 Windows Form 設計工具所需的呼叫。
//        InitializeComponent()

//        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。
//        CType(Grid1.Resources("storyBoard1"), Storyboard).Begin(Me, True)


//        '在到達下個時鐘刻度時，搜尋這個 Storyboard 直到新位置
//        'instance.Seek(containingObject, offset, origin)

//        '        ()
//        'offset :型別：System..::.TimeSpan

//        'offset: 正值或負值，描述時刻表應該從指定的 origin 向前移動或向後移動的數量。


//        CType(Grid1.Resources("storyBoard1"), Storyboard).Seek(Me, DateTime.Now.TimeOfDay, TimeSeekOrigin.BeginTime)

//        Dim timer1 As New System.Windows.Threading.DispatcherTimer()
//        AddHandler timer1.Tick, AddressOf timer_tick

//        timer1.Start()


//    End Sub

//    Sub timer_tick(ByVal sender As Object, ByVal e As EventArgs)

//        Me.textBlock1.Text = Date.Now.ToLongTimeString()

//    End Sub
//End Class

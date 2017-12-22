
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

namespace WpfApplication1
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window_2D_動畫_使用_Path_3 : Window
    {
        public Window_2D_動畫_使用_Path_3()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        //{
        //            '<Ellipse.RenderTransform>
        //            '         <TransformGroup>
        //            '             <TranslateTransform X="-80" Y="-90" />
        //            '             <MatrixTransform x:Name="mt1" />
        //            '         </TransformGroup>
        //            '     </Ellipse.RenderTransform>

        //            '  <Ellipse.Triggers>
        //            '            <EventTrigger RoutedEvent="Page.Loaded">
        //            '                <BeginStoryboard>
        //            '                    <Storyboard RepeatBehavior="Forever" x:Name="Storyboard_1">
        //            '                        <MatrixAnimationUsingPath x:Name="MatrixAnimationUsingPath_1"
        //            'Storyboard.TargetName = "mt1"
        //            'Storyboard.TargetProperty = "Matrix"

        //            'Duration = "0:0:4"

        //            '                            >

        //            '                        </MatrixAnimationUsingPath>



        //            '                    </Storyboard>
        //            '                </BeginStoryboard>
        //            '            </EventTrigger>
        //            '        </Ellipse.Triggers>


        //            '================================================
        //            'MatrixAnimationUsingPath x:Name="MatrixAnimationUsingPath_1"
        //            'NOTE:  Why  X="-80" Y="-90" 
        //            'Ellipse 物件 在 Canvas 的座標(x,y) 加上  EllipseGemetry 上的每一個點(x,y) 成為 Ellipse 物件的新座標
                  PathGeometry  pg1 =  new PathGeometry();

                    pg1.AddGeometry(this.EllipseGemetry1);

                    this.MatrixAnimationUsingPath_1.PathGeometry = pg1;

                    this.Storyboard_1.Begin(this.ellipse1);;

        }

    }
}


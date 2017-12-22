
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
    public partial class Window_VidioText : Window
    {
        public Window_VidioText()
        {
            InitializeComponent();


                    // Create the text as FormattedText object.
                  FormattedText   formattedText   = new FormattedText( 
                          "FION", 
                          new System.Globalization.CultureInfo("en-US"), 
                          FlowDirection.LeftToRight, 
                          new Typeface( 
                              new FontFamily("Segoe UI"), 
                              FontStyles.Normal, 
                              FontWeights.Bold, 
                              FontStretches.Normal), 
                          120, 
                          Brushes.Yellow);

                    // Build a geometry out of the text.
                    //Dim geometry As New PathGeometry()
                  GeometryGroup   geometry = new  GeometryGroup();
                  geometry = (GeometryGroup)formattedText.BuildGeometry(new Point(0, 0));

                    // Adjust the geometry to fit the aspect ration of the video by scaling it.
                  ScaleTransform   myScaleTransform  = new ScaleTransform();
                    //'myScaleTransform.ScaleX = 0.85
                    //'myScaleTransform.ScaleY = 2.0
                    myScaleTransform.ScaleX = 1;
                    myScaleTransform.ScaleY = 1;

                    geometry.Transform = myScaleTransform;

                    //'// Flatten the geometry and create a PathGeometry out of it.
                  PathGeometry   PathGeometry = new PathGeometry();
                    PathGeometry = geometry.GetFlattenedPathGeometry();


                    // Use the PathGeometry for the empty placeholder Path element in XAML.
                    path.Data = PathGeometry;

                    // Use the PathGeometry to clip the video.
                    myMediaElement.Clip = PathGeometry;

                    // Use the PathGeometry for the animated ball that follows the path of the text outline.
                    matrixAnimation.PathGeometry = PathGeometry;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}


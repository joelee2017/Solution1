
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
using Microsoft.Win32;
using System.IO;
using System.Windows.Ink;

namespace Demo
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window_InkCanvasSave_VisualBrush : Window
    {
        public Window_InkCanvasSave_VisualBrush()
        {
            InitializeComponent();
        }
      

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
 
            try
            {
                //'http://q.yesky.com/group/review-17580341.html
                //'            什么是isf？ 
              


                //'=======================================
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "isf files (*.isf)|*.isf";

                if (saveFileDialog1.ShowDialog() == true)
                {
                    FileStream fs = new FileStream("Demo.isf", FileMode.Create);
                    ic.Strokes.Save(fs);

                    fs.Close();
                }


                MessageBox.Show("done");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {
 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "isf files (*.isf)|*.isf";

            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                ic.Strokes = new StrokeCollection(fs);
                fs.Close();
            }
        }
    }
}

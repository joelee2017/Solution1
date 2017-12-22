using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1._3_1.WPF_ControlsUI
{
    /// <summary>
    /// Window_MetroUI.xaml 的互動邏輯
    /// </summary>
    public partial class Window_MetroUI : Window
    {
        public Window_MetroUI()
        {
            InitializeComponent();

            System.Random r = new Random();
            global::DataModel.AdventureWorksEntities dbContext = new DataModel.AdventureWorksEntities();

            var q = from p in dbContext.ProductPhoto
                    group p by p.ModifiedDate.Year;

            foreach(var group in q)
            {
                WrapPanel w = new WrapPanel();
                //w.Width = 200;
                w.Height = 200;
                w.Background = new SolidColorBrush(Colors.AliceBlue);
                w.Margin = new Thickness(3);
                w.Orientation = Orientation.Vertical;//垂直顯示
                

                this.stackPanel.Children.Add(w);

               
                //foreach(var item in group)
                //{
                //    Button btn = new Button();
                //    btn.Width = 50;
                //    btn.Height = 50;
                //    btn.Content = item.ModifiedDate;
                //    btn.Margin = new Thickness(3);

                //    w.Children.Add(btn);
                //}

                foreach (var item in group)
                {
                    UserControl_Page up = new UserControl_Page();
                    up.Desc = item.ModifiedDate.ToString();
                    up.Width = 50;
                    up.Height = 50;
                    up.Margin = new Thickness(3);
                    up.Imagebyte = item.LargePhoto;
                    
                    w.Children.Add(up);
                }
            }
        }
    }
}

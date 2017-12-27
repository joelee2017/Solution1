using DataModel;
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

namespace WpfApp1._4_1.WPF應用
{
    /// <summary>
    /// Window_Binding_DB.xaml 的互動邏輯
    /// </summary>
    public partial class Window_Binding_DB : Window
    {
        public Window_Binding_DB()
        {
            InitializeComponent();

            AdventureWorksEntities dbContext = new AdventureWorksEntities();
            var PrdouctList = dbContext.ProductPhoto.ToList();

            this.listBox3.ItemsSource = this.listBox2.ItemsSource = this.ListBox1.ItemsSource = PrdouctList;
        }
    }
}

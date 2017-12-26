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

namespace WpfApp_HW
{
    /// <summary>
    /// Window_MyBook.xaml 的互動邏輯
    /// </summary>
    public partial class Window_MyBook : Window
    {
        public Window_MyBook()
        {
            InitializeComponent();

            var PhotoList = global::PhotoDataModel_V2.PhotoDataSource.Search("car", 5);

            for(int i=1; i<= PhotoList.Count-1;i++)
            {
                UserControl_Page Page = new UserControl_Page();
                
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

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
    /// Window_Binding.xaml 的互動邏輯
    /// </summary>
    public partial class Window_Binding : Window
    {
        public Window_Binding()
        {
            InitializeComponent();
        }

        public class Employee //實作類別
        {
            public string EmpName { get; set; }
            public DateTime HireDate { get; set; }
            public string ImagePath { get; set; }

            public override string ToString()//將原顯示系統資料，覆蓋成內容值
            {
                return this.EmpName + "" + this.HireDate;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee
            { EmpName = "aaa", HireDate = DateTime.Now, ImagePath = @"\圖庫\1483503509137.jpg" };
            stackPanel.DataContext = emp;//DataContext內容來源 EMP
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { EmpName = "aaa", HireDate = DateTime.Now, ImagePath = @"\圖庫\1483503509137.jpg" });
            empList.Add(new Employee { EmpName = "bbb", HireDate = DateTime.Now.AddHours(8), ImagePath = @"\圖庫\1483601992641.jpg" });
            empList.Add(new Employee { EmpName = "ccc", HireDate = DateTime.Now.AddDays(-3), ImagePath = @"\圖庫\153H13c2-1.jpg" });

            listbox3.ItemsSource  = listbox2.ItemsSource  = listbox1.ItemsSource = empList;
        }
    }


}

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

namespace WpfApp1
{
    /// <summary>
    /// Window_MyNotePad_Command.xaml 的互動邏輯
    /// </summary>
    public partial class Window_MyNotePad_Command : Window
    {
        public Window_MyNotePad_Command()
        {
            InitializeComponent();

            //ApplicationCommands.Paste
            //為了將程式前後端開發流程明簡化，所以將部份程式碼以Commands方式，寫在前端之中
            //MVVM -View -VM -Model
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox1.Cut();
        }

        //private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        //{
        //    this.TextBox1.Copy();
        //}

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.TextBox1.Foreground = new SolidColorBrush(Colors.Red);
            //SolidColorBrush 新增筆刷
        }
    }
}

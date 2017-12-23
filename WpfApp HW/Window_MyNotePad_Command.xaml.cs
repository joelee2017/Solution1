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

        private void MenuItem_Click(object sender, RoutedEventArgs e)//剪下
        {
            this.TextBox1.Cut();
        }

        //private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        //{
        //    this.TextBox1.Copy();
        //}

        private void RadioButton_Checked(object sender, RoutedEventArgs e)//色系改變
        {
            this.TextBox1.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)//色系改變
        {
            this.TextBox1.Foreground = new SolidColorBrush(Colors.Lime);
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)//色系改變
        {
            this.TextBox1.Foreground = new SolidColorBrush(Colors.Blue);
        }


        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)//色系改變
        {
            this.TextBox1.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void btnBold_Click(object sender, RoutedEventArgs e)
        {
            if(this.TextBox1.FontWeight == FontWeights.ExtraBold)//如果是粗體
            {
                this.TextBox1.FontWeight = FontWeights.Normal;//就回復
            }
            else
            {
                this.TextBox1.FontWeight = FontWeights.ExtraBold;//如果不是粗體就變成粗體
            }
        }

        private void btnItalic_Click(object sender, RoutedEventArgs e)//斜體
        {
            if(this.TextBox1.FontStyle == FontStyles.Italic)
            {
                this.TextBox1.FontStyle = FontStyles.Normal;
            }
            else
            {
                this.TextBox1.FontStyle = FontStyles.Italic;
            }
        }

        private void btnUnderLine_Click(object sender, RoutedEventArgs e)//加底線
        {
            if(this.TextBox1.TextDecorations == TextDecorations.Underline)
            {
                this.TextBox1.TextDecorations = null;
            }
            else
            {
                this.TextBox1.TextDecorations = TextDecorations.Underline;
            }
        }
        
        private void Open_Click(object sender, RoutedEventArgs e)//打開文件
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            //表示通用對話方塊中，可讓使用者指定要開啟的一或多個檔案的檔名。

            dlg.DefaultExt = ".txt";
            dlg.Filter = "Txt|*.txt|CS|*.cs|XAML|*.xaml";

            Nullable<bool> result = dlg.ShowDialog();//支援實值類型可以指派null。 這個類別無法被繼承。
                if(result ==true)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(dlg.FileName))
                {
                    this.TextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)//關閉視窗
        {
            this.Close();
        }
    }
}

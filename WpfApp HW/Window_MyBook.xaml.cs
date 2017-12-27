using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//Load
        {
            this.Cursor = Cursors.Wait;//等待沙漏

            
            Window win = new Window();
            win.Width = 300;
            win.Height = 100;
            win.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            win.Content = "請稍等~~~~~";

            win.WindowStyle = WindowStyle.None;
            win.BorderBrush = Brushes.AliceBlue;
            win.BorderThickness = new Thickness(10);
            win.FontSize = 30;

            win.Show();

            //===============================================================================
            var PhotoList = global::PhotoDataModel_V2.PhotoDataSource.Search("car", 50);

            for (int i = 1; i <= PhotoList.Count - 1; i++)
            {
                UserControl_Page Page = new UserControl_Page();
                Page.Margin = new Thickness(3);

                Page.Desc = PhotoList[i].Title;
                Page.ImageURL = PhotoList[i].ImagePath;

                if(PhotoList[i].UniqueId !=null)
                {
                    Page.Id = PhotoList[i].UniqueId;
                }
                else
                {
                    Page.Id = Guid.NewGuid().GetHashCode().ToString();
                    Page.NotifyMyFavor += Page_NotifyMyFavor;
                   
                    this.MyBook.Items.Add(Page);
                }
                win.Close();
                this.Cursor = null;
            }
        }

        private void Page_NotifyMyFavor(object sender, bool? IsFavor)//將圖片加入自製控制項
        {
            var item = (UserControl_Page)sender;//serder 轉控制項
            string ItemID = item.Id;

            if(IsFavor.Value)//將圖片加入 群組
            {
                Image x = new Image()
                {
                    Source = item.ImageSource,
                    Width = 50,
                    Height = 40,
                    Margin = new Thickness(3),
                    Stretch = Stretch.Fill,
                    Tag = item.Id,
                };
                this.stackPanel.Children.Add(x);
            }

            else //將圖片移除群組
            {
              var removeItem = 
                this.stackPanel.Children.Cast<Image>().FirstOrDefault(p => p.Tag.ToString() == ItemID);

                this.stackPanel.Children.Remove(removeItem);
            }
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            switch(btn.Name.ToString().ToLower())
            {
                case "upage":
                    this.MyBook.AnimateToPreviousPage(true, 500);
                    break;
                case "dpage":
                    this.MyBook.AnimateToNextPage(true, 500);
                    break;
                case "first":
                    this.MyBook.CurrentSheetIndex = 0; //頁首
                    break;
                case "last":
                    this.MyBook.CurrentSheetIndex = this.MyBook.Items.Count / 2;
                    break;
            }
        }
    }
}

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
    /// Window_MyBook.xaml 的互動邏輯
    /// </summary>
    public partial class Window_MyBook : Window
    {
        public Window_MyBook()
        {
            InitializeComponent();


            var PhotoList= global::PhotoDataModel_V2.PhotoDataSource.Search("car", 5);
            
            for (int i = 1; i <= PhotoList.Count-1; i++)
            {
                UserControl_Page Page = new UserControl_Page();
                Page.Desc = PhotoList[i].Title;
                Page.ImageURL = PhotoList[i].ImagePath;

                this.MyBook.Items.Add(Page);
            }


            //=========================================================
            global::DataModel.AdventureWorksEntities dbContext = new DataModel.AdventureWorksEntities();
            var ProdutList = dbContext.ProductPhoto.ToList();

            for(int i=1; i<= ProdutList.Count-1 ;i++)
            {
                UserControl_Page Page = new UserControl_Page();
                Page.Desc = ProdutList[i].ModifiedDate.ToShortDateString();
                Page.Imagebyte = ProdutList[i].LargePhoto;
                this.MyBook.Items.Add(Page);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.MyBook.AnimateToNextPage(true, 500);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.MyBook.AnimateToPreviousPage(true, 500);
        }
    }
}


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

namespace WpfApplication1._4._WPF_多媒體應用
{
    /// <summary>
    /// Window_DataSourceTool_DataGrid.xaml 的互動邏輯
    /// </summary>
    public partial class Window_CRUD_Starter : Window
    {
        public Window_CRUD_Starter()
        {
            InitializeComponent();
        }

        System.Windows.Data.CollectionViewSource productPhotoViewSource;

        global::DataModel.AdventureWorksEntities dbContext;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           productPhotoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productPhotoViewSource")));
            // 透過設定 CollectionViewSource.Source 屬性載入資料: 

             dbContext = new DataModel.AdventureWorksEntities();
            dbContext.ProductPhoto.ToList();


            //ObservableCollection<TEntity>
            //當從內容中加入或移除實體時，此本機檢視會維持同步的狀態。
            //同樣地，從本機檢視加入或移除的實體將會自動加入至內容中或是從內容中移除。
            productPhotoViewSource.Source = dbContext.ProductPhoto.Local;
        }

        private void Button_Click(object sender, RoutedEventArgs e)//上一筆
        {
            this.productPhotoViewSource.View.MoveCurrentToPrevious();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//下一筆
        {
            this.productPhotoViewSource.View.MoveCurrentToNext();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//查詢
        {

            int min = int.Parse(this.textBox1.Text);
            int max = int.Parse(this.textBox2.Text);

            var q = this.dbContext.ProductPhoto.Where
                               (p => p.ModifiedDate.Year >= min && p.ModifiedDate.Year <= max);

            this.productPhotoViewSource.Source = q.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)//新增
        {
            this.dbContext.ProductPhoto.Local.Add(
                new ProductPhoto
                { LargePhotoFileName = "xxx " + DateTime.Now.ToLongTimeString(), ModifiedDate = DateTime.Now });

            //移動追蹤
            this.productPhotoViewSource.View.MoveCurrentToLast();
            this.productPhotoDataGrid.ScrollIntoView(this.productPhotoViewSource.View.CurrentItem);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)//儲存
        {
            dbContext.SaveChanges();//存到DB
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)//刪除
        {
            int Pos = this.productPhotoViewSource.View.CurrentPosition;

            this.dbContext.ProductPhoto.Local.RemoveAt(Pos);

            //移動追蹤
            this.productPhotoViewSource.View.MoveCurrentToPosition(Pos - 1);
            this.productPhotoDataGrid.ScrollIntoView(this.productPhotoViewSource.View.CurrentItem);//移動追蹤

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)//修改
        {
            int Pos = this.productPhotoViewSource.View.CurrentPosition;
            var prod = (ProductPhoto)this.productPhotoViewSource.View.CurrentItem;

            //修改填入值
            prod.ModifiedDate = DateTime.Now;
            prod.LargePhotoFileName = DateTime.Now.ToShortTimeString();

            //移動追蹤
            this.productPhotoViewSource.View.MoveCurrentToLast();
            this.productPhotoDataGrid.ScrollIntoView(this.productPhotoViewSource.View.CurrentItem);
        }
    }
}

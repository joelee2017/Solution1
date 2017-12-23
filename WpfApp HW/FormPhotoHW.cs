using PhotoDataModel_V2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace WpfApp_HW
{
    public partial class FormPhotoHW : Form
    {
        public FormPhotoHW()
        {
            InitializeComponent();
        }

        List<PhotoDataItem> PhotoList = new List<PhotoDataItem>();

        async private void btnGetPhoto_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            List<PhotoDataItem> PhotoList = await PhotoDataSource.SearchAsync("car", 10);

            for (int i=0; i < PhotoList.Count-1; i++)
            {
                MyItemTemplate x = new MyItemTemplate();
                x.Desc = PhotoList[i].Title;
                x.ImageUrl = PhotoList[i].ImagePath;
                this.flowLayoutPanel1.Controls.Add(x);

                //==============================================
                
                MyItemTemplate y = new MyItemTemplate();
                y.Desc = PhotoList[i].Title;
                y.ImageUrl = PhotoList[i].ImagePath;
                this.flowLayoutPanel2.Controls.Add(y);


                if (PhotoList[i].UniqueId != null)
                {
                    x.Id = PhotoList[i].UniqueId;
                    y.Id = PhotoList[i].UniqueId;
                }
                else
                {
                    x.Id = Guid.NewGuid().GetHashCode().ToString();
                    x.NotifyMyFavor += X_NotifyMyFavor;
                    this.flowLayoutPanel1.Controls.Add(x);

                    y.Id = Guid.NewGuid().GetHashCode().ToString();
                    y.NotifyMyFavor += X_NotifyMyFavor;
                    this.flowLayoutPanel2.Controls.Add(y);

                }

                Application.DoEvents();


            }
        }
         

        private void X_NotifyMyFavor(object sender, bool IsFavor)
        {
            var item = (MyItemTemplate)sender;
            string ItemId = item.Id;
            PictureBox x = new PictureBox
            {
                Image = item.Ptimage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = item.Id,
                Name = item.Id
            };

            if (IsFavor)
            {
                this.flowLayoutPanel3.Controls.Add(x);
            }
            else
            {
                var removeItem = this.flowLayoutPanel3.Controls.Find(ItemId.ToString(), true)[0];

                this.flowLayoutPanel3.Controls.Remove(removeItem);
            }


        }

    }
}

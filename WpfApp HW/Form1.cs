﻿using DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;
using System.Data.SqlClient;
using WpfApp_HW.Properties;
using PhotoDataModel_V2;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.flowLayoutPanel2.AutoScroll = true;
            
        }

        /// <summary>
        /// dbContext.Database.Log=Console.Write; 監視檔案
        /// dbContext.ProductPhoto.Local; 將select 出來的資料放在Local中
        ///
        /// </summary>
        AdventureWorksEntities dbContext = new AdventureWorksEntities();
        private void GetProductPhoto_Click(object sender, EventArgs e)
        {
            var query = from p in dbContext.ProductPhoto
                        select p;
            dbContext.Database.Log=Console.Write;
            this.dataGridView1.DataSource = query.ToList();

            //Local =ObservableCollection<ProductPhoto>
            this.dataGridView2.DataSource = dbContext.ProductPhoto.Local;

        }

        /// <summary>
        /// ADO.NET 寫法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetphotoADOnet_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.DataBindings.Clear();
            List<UserControl1> Uscommtool = new List<UserControl1>();
            UserControl1 us1 = new UserControl1();
            string ADW = Settings.Default.ADVW;
            string commtxt = 
                "select LargePhoto,LargePhotoFileName from Production.ProductPhoto";
            using (SqlConnection conn = new SqlConnection(ADW))
            {
                using (SqlCommand comm = new SqlCommand(commtxt, conn))
                {
                    conn.Open();
                    SqlDataReader dataReader = comm.ExecuteReader();
                    while (dataReader.Read())
                    {
                        byte[] by = (byte[])dataReader["LargePhoto"];
                        string name = (string)dataReader["LargePhotoFileName"];
                        UserControl1 us = new UserControl1();
                        using (MemoryStream ms = new MemoryStream(by))
                        {
                            us.Btnpicture = Image.FromStream(ms);
                            us.BtnName = name;
                        }
                        Uscommtool.Add(us);
                    }                  
                }
            }
            for (int i = 0; i <= Uscommtool.Count - 1; i++)
            {
                flowLayoutPanel1.Controls.Add(Uscommtool[i]);
            }


        }

        private void btnGetPhotoLINQ_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.DataBindings.Clear();
            //LINQ
            var query = from ph in dbContext.ProductPhoto
                        select ph.LargePhoto;

            //Lambda
           // var query1 = dbContext.ProductPhoto.Select(p => p.LargePhoto);

            foreach (var s in query)
            {                
                PictureBox ptb = new PictureBox();
                ptb.Size = new Size(125, 100);
                ptb.BackColor = Color.White;
                ptb.MouseEnter += Ptb_MouseEnter;
                ptb.MouseLeave += Ptb_MouseLeave;

                using (MemoryStream ms = new MemoryStream(s))
                {
                    ptb.Image = Image.FromStream(ms);
                }
                this.flowLayoutPanel2.Controls.Add(ptb);
            }
        }

        private void Ptb_MouseLeave(object sender, EventArgs e)
        {
            PictureBox ptbML = ((PictureBox)sender);
            ptbML.Size =new Size(125, 100);
            ptbML.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Ptb_MouseEnter(object sender, EventArgs e)//圖片寫入容器事件
        {
            PictureBox ptbME = ((PictureBox)sender);//圖片控制項轉成事件
            ptbME.Size = new Size(150, 200);
            ptbME.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnGetPhoto_Click(object sender, EventArgs e)//匯入圖片
        {
            flowLayoutPanel1.DataBindings.Clear();
            flowLayoutPanel2.DataBindings.Clear();
            //var ProductList= this.dbContext.ProductPhoto.ToList();
            List<ProductPhoto> ProductList = this.dbContext.ProductPhoto.ToList();

            for(int i=0; i<=ProductList.Count-1;i++)
            {
                MyItemTemplate x = new MyItemTemplate();//自製方法宣告

                //
                x.Desc = ProductList[i].ModifiedDate.ToShortDateString();
                x.ImageBytes = ProductList[i].LargePhoto;
                //x.ImageURL=
                this.flowLayoutPanel2.Controls.Add(x);
                //=========================================
                // 屬性 Wrap Contents 換行栽剪 橫式顯示
                MyItemTemplate y = new MyItemTemplate();
                y.Desc = ProductList[i].ModifiedDate.ToShortDateString();
                y.ImageBytes = ProductList[i].LargePhoto;
                //x.ImageURL=
                this.flowLayoutPanel1.Controls.Add(y);


                Application.DoEvents();//將訊息處理完後在傳出
            }
        }



        private void btnAddMyItem_Click(object sender, EventArgs e)//加到最愛
        {

            List<ProductPhoto> ProductList = this.dbContext.ProductPhoto.ToList();
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                MyItemTemplate x = (MyItemTemplate)flowLayoutPanel1.Controls[i];
                if (x.DscCheck == true)
                {
                    x.Desc = ProductList[i].ModifiedDate.ToShortDateString();
                    x.ImageBytes = ProductList[i].LargePhoto;
                    this.flowLayoutPanel3.Controls.Add(x);
                }               
            }
        }

        //=====================================================================================================

        /// <summary>
        /// 呼叫外部方案進來，使用外部功能
        /// global::PhotoDataModel_V2.PhotoDataSource.Search();
        /// global NameSpace的父類別
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void btnRemotePhoto_Click(object sender, EventArgs e)//網頁照片匯入
        {
            flowLayoutPanel1.Controls.Clear();
            //List<PhotoDataItem> PhotoList =  global::PhotoDataModel_V2.PhotoDataSource.Search("car", 5);
            List<PhotoDataItem> PhotoList = await PhotoDataSource.SearchAsync("car", 5);
            for (int i = 0; i < PhotoList.Count - 1; i++)
            {
                MyItemTemplate x = new MyItemTemplate();
                x.Desc = PhotoList[i].Title;
                x.ImageUrl = PhotoList[i].ImagePath;

                if (PhotoList[i].UniqueId != null)
                {
                    x.Id = PhotoList[i].UniqueId;
                }
                else
                {
                    x.Id = Guid.NewGuid().ToString();

                    x.NotifyMyFavor += X_NotifyMyFavor;
                    this.flowLayoutPanel1.Controls.Add(x);
                }
                Application.DoEvents();
            }
        }

        private void X_NotifyMyFavor(object sender, bool IsFavor)
        {
            var item = (MyItemTemplate)sender;
            string itemID = item.Id;
            PictureBox x = new PictureBox
            {
                Image = item.Ptimage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = item.Id,
                Name = item.Id
            };

            if (IsFavor)
            {
                this.flowLayoutPanel1.Controls.Add(x);
            }
            else
            {
                var removeItem = this.flowLayoutPanel3.Controls.Find(itemID.ToString(), true)[0];

                this.flowLayoutPanel3.Controls.Remove(removeItem);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();
        }


        private void AddMyItem_V2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count +1; i++)
            {
                //List<MyItemTemplate> s = new List<MyItemTemplate>();
                foreach (MyItemTemplate x in flowLayoutPanel1.Controls)
                {
                    if (x.DscCheck == true)
                    {
                        this.flowLayoutPanel3.Controls.Add(x);
                    }
                }
            }


        }


    }
}

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
using WindowsFormsApp1.Properties;
using WindowsFormsControlLibrary1;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// dbContext.Database.Log=Console.Write; 監視檔案
        /// dbContext.ProductPhoto.Local; 將select 出來的資料放在Local中
        ///
        /// </summary>
        AdventureWorksEntities dbContext = new AdventureWorksEntities();
        private void myButton1_Click(object sender, EventArgs e)
        {
            var query = from p in dbContext.ProductPhoto
                        select p;

            dbContext.Database.Log=Console.Write;

            this.dataGridView1.DataSource = query.ToList();

            //Local =ObservableCollection<ProductPhoto>
            this.dataGridView2.DataSource = dbContext.ProductPhoto.Local;

        }

        private void myButton2_Click(object sender, EventArgs e)
        {
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
    }
}

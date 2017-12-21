using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class MyItemTemplate : UserControl
    {
        public MyItemTemplate()
        {
            InitializeComponent();
            this.pictureBox1.MouseEnter += PictureBox1_MouseEnter;//進入事件
            this.pictureBox1.MouseLeave += PictureBox1_MouseLeave;//離開事件
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.Orange;
            this.pictureBox1.Width -= 10; this.pictureBox1.Height -= 10;
            //離開時加顏色並縮小
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.White;
            this.pictureBox1.Width += 10; this.pictureBox1.Height += 10;
            //進入時加顏色並放大
        }

        public string Desc //文字 TextBox
        {
            get { return this.textBox1.Text; }

            set { this.textBox1.Text = value; }
        }

        public bool DscCheck //勾選 CheckBox
        {
            get { return checkBox1.Checked; }

            set { this.checkBox1.Checked = true; }
        }

        public byte[] ImageBytes // 圖片 PictureBox
        { set {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                                    this.pictureBox1.Image = Image.FromStream(ms);
              }

        }
        public string ImageUrl
        {
            set
            {
                if (value != null)
                    this.pictureBox1.Load(value);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

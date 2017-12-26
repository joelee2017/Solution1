namespace WpfApp_HW
{
    partial class FormPhotoHW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGetPhoto = new WindowsFormsControlLibrary1.MyButton();
            this.tableAdapterManager1 = new WpfApp_HW.ADWDataSet1TableAdapters.TableAdapterManager();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(177, 171);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(529, 368);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(712, 171);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(165, 368);
            this.flowLayoutPanel2.TabIndex = 14;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(708, 153);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnGetPhoto
            // 
            this.btnGetPhoto.FillColor1 = System.Drawing.Color.Red;
            this.btnGetPhoto.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGetPhoto.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.btnGetPhoto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPhoto.Location = new System.Drawing.Point(3, 156);
            this.btnGetPhoto.Name = "btnGetPhoto";
            this.btnGetPhoto.Size = new System.Drawing.Size(143, 61);
            this.btnGetPhoto.TabIndex = 15;
            this.btnGetPhoto.Text = "GetPhoto";
            this.btnGetPhoto.Click += new System.EventHandler(this.btnGetPhoto_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.ProductPhotoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WpfApp_HW.ADWDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormPhotoHW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 551);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.btnGetPhoto);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormPhotoHW";
            this.Text = "FormPhotoHW";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private WindowsFormsControlLibrary1.MyButton btnGetPhoto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ADWDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        //private WpfApp1._4_1.WPF應用.Window_MyClock userControl_MyClock1;
    }
}
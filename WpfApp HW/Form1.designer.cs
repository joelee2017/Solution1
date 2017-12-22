namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddMyItem = new WindowsFormsControlLibrary1.MyButton();
            this.myButton5 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton4 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton3 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton2 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton1 = new WindowsFormsControlLibrary1.MyButton();
            this.AddMyItem_V2 = new WindowsFormsControlLibrary1.MyButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(619, 37);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(250, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(619, 35);
            this.dataGridView2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(250, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(769, 173);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(831, 311);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(188, 402);
            this.flowLayoutPanel2.TabIndex = 6;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(250, 311);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(564, 401);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // btnAddMyItem
            // 
            this.btnAddMyItem.FillColor1 = System.Drawing.Color.Red;
            this.btnAddMyItem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddMyItem.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.btnAddMyItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMyItem.Location = new System.Drawing.Point(37, 311);
            this.btnAddMyItem.Name = "btnAddMyItem";
            this.btnAddMyItem.Size = new System.Drawing.Size(143, 61);
            this.btnAddMyItem.TabIndex = 10;
            this.btnAddMyItem.Text = "AddMyItem";
            this.btnAddMyItem.Click += new System.EventHandler(this.btnAddMyItem_Click);
            // 
            // myButton5
            // 
            this.myButton5.FillColor1 = System.Drawing.Color.Red;
            this.myButton5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.myButton5.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton5.Location = new System.Drawing.Point(37, 419);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(143, 61);
            this.myButton5.TabIndex = 8;
            this.myButton5.Text = "RemotePhoto";
            this.myButton5.Click += new System.EventHandler(this.btnRemotePhoto_Click);
            // 
            // myButton4
            // 
            this.myButton4.FillColor1 = System.Drawing.Color.Red;
            this.myButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.myButton4.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton4.Location = new System.Drawing.Point(37, 237);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(143, 61);
            this.myButton4.TabIndex = 7;
            this.myButton4.Text = "GetPhoto";
            this.myButton4.Click += new System.EventHandler(this.btnGetPhoto_Click);
            // 
            // myButton3
            // 
            this.myButton3.FillColor1 = System.Drawing.Color.Red;
            this.myButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.myButton3.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton3.Location = new System.Drawing.Point(37, 170);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(143, 61);
            this.myButton3.TabIndex = 3;
            this.myButton3.Text = "GetPhotoLINQ";
            this.myButton3.Click += new System.EventHandler(this.btnGetPhotoLINQ_Click);
            // 
            // myButton2
            // 
            this.myButton2.FillColor1 = System.Drawing.Color.Yellow;
            this.myButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.myButton2.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton2.Location = new System.Drawing.Point(37, 118);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(143, 46);
            this.myButton2.TabIndex = 2;
            this.myButton2.Text = "GetphotoADO.NET";
            this.myButton2.Click += new System.EventHandler(this.GetphotoADOnet_Click);
            // 
            // myButton1
            // 
            this.myButton1.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.myButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.myButton1.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.myButton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton1.Location = new System.Drawing.Point(37, 34);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(143, 69);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "GetProductPhoto";
            this.myButton1.Click += new System.EventHandler(this.GetProductPhoto_Click);
            // 
            // AddMyItem_V2
            // 
            this.AddMyItem_V2.FillColor1 = System.Drawing.Color.Red;
            this.AddMyItem_V2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddMyItem_V2.FillShape = WindowsFormsControlLibrary1.MyButton.Shape.Ellipse;
            this.AddMyItem_V2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMyItem_V2.Location = new System.Drawing.Point(51, 505);
            this.AddMyItem_V2.Name = "AddMyItem_V2";
            this.AddMyItem_V2.Size = new System.Drawing.Size(118, 48);
            this.AddMyItem_V2.TabIndex = 12;
            this.AddMyItem_V2.Text = "AddMyItem_V2";
            this.AddMyItem_V2.Click += new System.EventHandler(this.AddMyItem_V2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 724);
            this.Controls.Add(this.AddMyItem_V2);
            this.Controls.Add(this.btnAddMyItem);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.myButton5);
            this.Controls.Add(this.myButton4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.myButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.MyButton myButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsControlLibrary1.MyButton myButton2;
        private WindowsFormsControlLibrary1.MyButton myButton3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private WindowsFormsControlLibrary1.MyButton myButton4;
        private WindowsFormsControlLibrary1.MyButton myButton5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private WindowsFormsControlLibrary1.MyButton btnAddMyItem;
        private WindowsFormsControlLibrary1.MyButton AddMyItem_V2;
        private System.Windows.Forms.Timer timer1;
    }
}


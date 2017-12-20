using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{

    /// <summary>
    /// 創造自己的Button控制項含實作顏色、形狀、屬性
    /// 顏色屬性 FillColor1, FillColor2
    /// 形狀 Ellipse, Rectangle
    /// </summary>
    public class MyButton :Control
    {
        public MyButton()
        {
            this.FillColor1 = Color.Orange;
            this.FillColor2 = Color.Gray;
        }
        
        public Color FillColor1 { get; set; }
        public Color FillColor2 { get; set; }

        public enum Shape { Ellipse, Rectangle}


        /// <summary>
        /// 創建控制項欄位，失效時能自動重繪
        /// </summary>
        private Shape m_FillShape;
        public Shape FillShape
        {
            get { return m_FillShape; }
            set { m_FillShape = value; this.Invalidate(); }
        }


        /// <summary>
        /// GDI + => XAML UI
        /// OnPaint事件
        /// LinearGradientBrush ，using System.Drawing.Drawing2D;
        /// 指定的點和色彩，初始化 System.Drawing.Drawing2D.LinearGradientBrush 類別的新執行個體。
        /// ClientRectangle.Height 控制項工作區矩形，結構高度
        ///  g.FillEllipse(brush1, this.ClientRectangle);
        ///  橢圓(顏色，取得控制項工作區域)
        ///  g.SmoothingMode = SmoothingMode.AntiAlias;
        /// 反鋸齒
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Point pt1 = new Point(0,0);
            Point pt2 = new Point(0, this.ClientRectangle.Height);

            LinearGradientBrush brush1 = new LinearGradientBrush
                                        (pt1,pt2, this.FillColor1, this.FillColor2);

            switch(this.FillShape)//創建兩種屬性 圓形、長方形
            {
                case Shape.Ellipse:
                    g.FillEllipse(brush1, this.ClientRectangle);
                    break;
                case Shape.Rectangle:
                    g.FillRectangle(brush1, this.ClientRectangle);
                    break;
            }

            //g.FillEllipse(brush1, this.ClientRectangle);


            //=========================================
            //Draw String 顯示字型屬性(形狀中的 文字置中)
            float x, y;
            x = (this.ClientRectangle.Width - g.MeasureString(base.Text, base.Font).Width) / 2;
            y = (this.ClientRectangle.Height - g.MeasureString(base.Text, base.Font).Height) / 2;
            g.DrawString(base.Text, base.Font, Brushes.White, x, y);
        }
    }
}

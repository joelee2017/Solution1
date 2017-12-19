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
    /// </summary>
   public class MyButton :Control
    {
        public Color FillColor1 { get; set; }
        public Color FillColor2 { get; set; }

        public enum Shape { Ellipse, Rectangle}
        public Shape FillShape { get; set; }


        /// <summary>
        /// GDI + => XAML UI
        /// OnPaint事件
        /// LinearGradientBrush ，using System.Drawing.Drawing2D;
        /// 指定的點和色彩，初始化 System.Drawing.Drawing2D.LinearGradientBrush 類別的新執行個體。
        /// ClientRectangle.Height 控制項工作區矩形，結構高度
        ///  g.FillEllipse(brush1, this.ClientRectangle);
        ///  橢圓(顏色，取得控制項工作區域)
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point pt1 = new Point(0,0);
            Point pt2 = new Point(0, this.ClientRectangle.Height);

            LinearGradientBrush brush1 = new LinearGradientBrush
                                        (pt1,pt2, this.FillColor1, this.FillColor2);
            g.FillEllipse(brush1, this.ClientRectangle);
        }
    }
}

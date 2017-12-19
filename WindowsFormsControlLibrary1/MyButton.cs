using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControlLibrary1
{
    /// <summary>
    /// 創造自己的Button控制項含實作顏色、形狀、屬性
    /// </summary>
   public class MyButton
    {
        public Color FillColor1 { get; set; }
        public Color FillColor2 { get; set; }

        public enum Shape { Ellipse, Rectangle}
        public Shape FillShape { get; set; }

    }
}

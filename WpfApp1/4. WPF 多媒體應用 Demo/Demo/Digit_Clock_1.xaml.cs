using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Window3.xaml 的互動邏輯
    /// </summary>
    public partial class Digit_Clock_1 : Window
    {
        public Digit_Clock_1()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            //     ClearDisplay(sender); 
            //Canvas = sender; 
            //ShowCurrentTime();   
        }
    }
}
//        function ShowOne(sender,args)
//{
//    ShowNumber(sender,1)
//}
//function ShowTwo(sender,args)
//{
//    ShowNumber(sender,2)
//}
//function ShowThree(sender,args)
//{
//    ShowNumber(sender,3)
//}
//function ShowFour(sender,args)
//{
//    ShowNumber(sender,4)
//}
//function ShowFive(sender,args)
//{
//    ShowNumber(sender,5)
//}
//function ShowSix(sender,args)
//{
//    ShowNumber(sender,6)
//}
//function ShowSeven(sender,args)
//{
//    ShowNumber(sender,7)
//}
//function ShowEight(sender,args)
//{
//    ShowNumber(sender,8)
//}
//function ShowNine(sender,args)
//{
//    ShowNumber(sender,9)
//}
//function ShowZero(sender,args)
//{
//    ShowNumber(sender,0)
//}
//function ShowNumber(sender,num,strTime)
//{
//    switch(Number(num))
//    {
//    case 1:
//        sender.findName(strTime + "TopLeft").Opacity = "1.0";
//        sender.findName(strTime + "BottomLeft").Opacity = "1.0";
//    break;
//    case 2:
//        sender.findName(strTime + "Top").Opacity = "1.0";
//        sender.findName(strTime + "TopRight").Opacity = "1.0";
//        sender.findName(strTime + "Center").Opacity = "1.0";
//        sender.findName(strTime + "BottomLeft").Opacity = "1.0";
//        sender.findName(strTime + "Bottom").Opacity = "1.0";
//    break;
//    case 3:
//        sender.findName(strTime + "Top").Opacity = "1.0";
//        sender.findName(strTime + "TopRight").Opacity = "1.0";
//        sender.findName(strTime + "Center").Opacity = "1.0";
//        sender.findName(strTime + "BottomRight").Opacity = "1.0";
//        sender.findName(strTime + "Bottom").Opacity = "1.0";
//    break;
//    case 4:
//        sender.findName(strTime + "TopLeft").Opacity = "1.0";
//        sender.findName(strTime + "TopRight").Opacity = "1.0";
//        sender.findName(strTime + "Center").Opacity = "1.0";
//        sender.findName(strTime + "BottomRight").Opacity = "1.0";
//    break;
//    case 5:
//        sender.findName(strTime + "Top").Opacity = "1.0";
//        sender.findName(strTime + "TopLeft").Opacity = "1.0";
//        sender.findName(strTime + "Center").Opacity = "1.0";
//        sender.findName(strTime + "BottomRight").Opacity = "1.0";
//        sender.findName(strTime + "Bottom").Opacity = "1.0";
//    break;
//    case 6:
//        sender.findName(strTime + "Top").Opacity = "1.0";
//        sender.findName(strTime + "TopLeft").Opacity = "1.0";
//        sender.findName(strTime + "Center").Opacity = "1.0";
//        sender.findName(strTime + "BottomLeft").Opacity = "1.0";
//        sender.findName(strTime + "BottomRight").Opacity = "1.0";
//        sender.findName(strTime + "Bottom").Opacity = "1.0";
//    break;
//    case 7:
//        sender.findName(strTime + "Top").Opacity = "1.0";
//        sender.findName(strTime + "TopRight").Opacity = "1.0";
//        sender.findName(strTime + "BottomRight").Opacity = "1.0";
//    break;
//    case 8:
//        sender.findName(strTime + "Top").Opacity = "1.0";
//        sender.findName(strTime + "TopLeft").Opacity = "1.0";
//        sender.findName(strTime + "TopRight").Opacity = "1.0";
//        sender.findName(strTime + "Center").Opacity = "1.0";
//        sender.findName(strTime + "BottomLeft").Opacity = "1.0";
//        sender.findName(strTime + "BottomRight").Opacity = "1.0";
//        sender.findName(strTime + "Bottom").Opacity = "1.0";
//    break;
//    case 9:
//        sender.findName(strTime + "Top").Opacity = "1.0";
//        sender.findName(strTime + "TopLeft").Opacity = "1.0";
//        sender.findName(strTime + "TopRight").Opacity = "1.0";
//        sender.findName(strTime + "Center").Opacity = "1.0";
//        sender.findName(strTime + "BottomRight").Opacity = "1.0";
//        sender.findName(strTime + "Bottom").Opacity = "1.0";
//    break;
//    case 0:
//        sender.findName(strTime + "Top").Opacity = "1.0";
//        sender.findName(strTime + "TopLeft").Opacity = "1.0";
//        sender.findName(strTime + "TopRight").Opacity = "1.0";
//        sender.findName(strTime + "BottomLeft").Opacity = "1.0";
//        sender.findName(strTime + "BottomRight").Opacity = "1.0";
//        sender.findName(strTime + "Bottom").Opacity = "1.0";
//    break;
//    }
//}
//var Canvas = null;
//var Time = new Array("Hour1","Hour2","Min1","Min2","Sec1","Sec2");
//var Display = new Array("Top","TopLeft","TopRight","Center","BottomLeft","BottomRight","Bottom");
//function OnLoad(sender,args)
//{
//       ClearDisplay(sender); 
//       Canvas = sender; 
//       ShowCurrentTime();   
//}


//function ClearDisplay(sender)
//{
//    for(i = 0; i < Time.length; i++)
//    {
//        strTime = Time[i];
//        for(j = 0; j < Display.length;j++)
//        {
//            strDisplay = Display[j];
//            strVariable = strTime + strDisplay;
//            sender.findName(strVariable).Opacity = "0.1";        
//        }
//    }
//}
//function ShowCurrentTime()
//{
//     d = new Date();
//     HH = d.getHours();
//     MM = d.getMinutes();
//     SS = d.getSeconds();
//     H1 = HH.toString().substring(0,1);
//     H2 = HH.toString().substring(1,2)
//     M1 = MM.toString().substring(0,1)
//     M2 = MM.toString().substring(1,2)
//     S1 = SS.toString().substring(0,1)
//     S2 = SS.toString().substring(1,2) 
//     ClearDisplay(Canvas);
//     if(HH.toString().length == 2)
//     {
//        ShowNumber(Canvas,H1,"Hour1");
//        ShowNumber(Canvas,H2,"Hour2");
//     }
//     else
//     {
//        ShowNumber(Canvas,0,"Hour1");
//        ShowNumber(Canvas,H1,"Hour2");
//     }
//     if(MM.toString().length == 2)
//     {
//        ShowNumber(Canvas,M1,"Min1");
//        ShowNumber(Canvas,M2,"Min2");
//     }
//     else
//     {
//        ShowNumber(Canvas,0,"Min1");
//        ShowNumber(Canvas,M1,"Min2");
//     }
//     if(SS.toString().length == 2)
//     {
//        ShowNumber(Canvas,S1,"Sec1");
//        ShowNumber(Canvas,S2,"Sec2");
//     }
//     else
//     {
//        ShowNumber(Canvas,0,"Sec1");
//        ShowNumber(Canvas,S1,"Sec2");
//     }
//     setTimeout("ShowCurrentTime()",100);    
//}
//    }
//}

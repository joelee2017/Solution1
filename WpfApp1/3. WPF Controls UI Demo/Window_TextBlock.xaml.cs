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
using System.Windows.Media.Animation;
using System.Diagnostics;

namespace WpfApplication__MyHomework_.TestControl
{
    /// <summary>
    /// Window_TextBlock.xaml 的互動邏輯
    /// </summary>
    public partial class Window_TextBlock : Window
    {
        public Window_TextBlock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Create and configure a simple color animation sequence.  Timespan is in 1000ns ticks.
            ColorAnimation colorAnimation = new ColorAnimation(Colors.Maroon, Colors.White, new Duration(new TimeSpan(1000000)));
            colorAnimation.AutoReverse = true;
            colorAnimation.RepeatBehavior = RepeatBehavior.Forever;

            // Create a new brush and apply the color animation.
            SolidColorBrush solidColorBrush = new SolidColorBrush(Colors.Black);
            solidColorBrush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);

            // Create a new TextEffect object. Set the foreground to the color-animated brush.
            TextEffect textEffect = new TextEffect();
            textEffect.Foreground = solidColorBrush;

            // Apply the TextEffect to the entire range of characters.
            textEffect.PositionStart = 0;
            textEffect.PositionCount = int.MaxValue;

            // Create a new text Run, and add the TextEffect to the TextEffectCollection of the Run.
            //取得或設定要套用至項目內容的文字效果集合。 
            Run flickerRun = new Run("Text that flickers...");
            flickerRun.TextEffects = new TextEffectCollection();
            flickerRun.TextEffects.Add(textEffect);

            this.textBlock1.Inlines.Clear();
            this.textBlock1.Inlines.Add(flickerRun);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //Run 內嵌層級非固定格式內容項目，主要是要包含已格式化或未格式化文字的執行。


            textBlock1.TextWrapping = TextWrapping.Wrap;
          
            textBlock1.Inlines.Add(new Bold(new Run("TextBlock")));
            textBlock1.Inlines.Add(new Run(" is designed to be "));
            textBlock1.Inlines.Add(new Italic(new Run("lightweight")));
          
            //  TextBlock 換行技巧 LineBreak
            textBlock1.Inlines.Add(new LineBreak());
            textBlock1.Inlines.Add(new Run(", and is geared specifically at integrating "));
            textBlock1.Inlines.Add(new Italic(new Run("small")));
            textBlock1.Inlines.Add(new Run(" portions of flow content into a UI."));
            textBlock1.Inlines.Add(new Run(", and is geared specifically at integrating "));
            textBlock1.Inlines.Add(new Italic(new Run("small")));
            textBlock1.Inlines.Add(new Run(" portions of flow content into a UI."));

        }

    
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(this.ScrollViewer1.ActualWidth+ ", " + this.ScrollViewer1.ActualHeight);

            //取得 Window ClientSize
            Debug.WriteLine(this.Grid1.ActualWidth + ", " + this.Grid1.ActualHeight);
            FrameworkElement pnlClient = this.Content as FrameworkElement;
            if (pnlClient != null)
            {
                Debug.WriteLine(pnlClient.ActualWidth + ", " + pnlClient.ActualWidth);
            } 
        }
    }
}

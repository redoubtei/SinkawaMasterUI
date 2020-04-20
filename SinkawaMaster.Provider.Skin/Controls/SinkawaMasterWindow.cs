using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shell;

namespace SinkawaMaster.Provider.Skin
{
    public class SinkawaMasterWindow : Window
    {
        #region 初始化
        public SinkawaMasterWindow()
        {
            var chrome = new WindowChrome
            {
                GlassFrameThickness = new Thickness(1),
                ResizeBorderThickness = new Thickness(4)
            };
            WindowChrome.SetWindowChrome(this, chrome);
        }
        #endregion

        #region 系统按钮

        /// <summary>
        /// 系统按钮背景色
        /// </summary>
        public Brush SystemButtonColor
        {
            get { return (Brush)GetValue(SystemButtonColorProperty); }
            set { SetValue(SystemButtonColorProperty, value); }
        }
        public static readonly DependencyProperty SystemButtonColorProperty =
            DependencyProperty.Register("SystemButtonColor", typeof(Brush), typeof(SinkawaMasterWindow), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0, 255, 255, 255))));

        /// <summary>
        /// 系统按钮大小
        /// </summary>
        public double SystemButtonSize
        {
            get { return (double)GetValue(SystemButtonSizeProperty); }
            set { SetValue(SystemButtonSizeProperty, value); }
        }
        public static readonly DependencyProperty SystemButtonSizeProperty =
            DependencyProperty.Register("SystemButtonSize", typeof(double), typeof(SinkawaMasterWindow), new PropertyMetadata(30.0));
        /// <summary>
        /// 系统按钮前景色
        /// </summary>
        public Brush SystemButtonForeground
        {
            get { return (Brush)GetValue(SystemButtonForegroundProperty); }
            set { SetValue(SystemButtonForegroundProperty, value); }
        }
        public static readonly DependencyProperty SystemButtonForegroundProperty =
            DependencyProperty.Register("SystemButtonForeground", typeof(Brush), typeof(SinkawaMasterWindow), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(88, 88, 88))));

        /// <summary>
        /// 系统按钮悬浮背景色
        /// </summary>
        public Brush SystemButtonOverColor
        {
            get { return (Brush)GetValue(SystemButtonOverColorProperty); }
            set { SetValue(SystemButtonOverColorProperty, value); }
        }
        public static readonly DependencyProperty SystemButtonOverColorProperty =
            DependencyProperty.Register("SystemButtonOverColor", typeof(Brush), typeof(SinkawaMasterWindow), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(40, 255, 255, 255))));



        /// <summary>
        /// 关闭按钮悬浮背景色
        /// </summary>
        public Brush SystemButtonCloseOverColor
        {
            get { return (Brush)GetValue(SystemButtonCloseOverColorProperty); }
            set { SetValue(SystemButtonCloseOverColorProperty, value); }
        }
        public static readonly DependencyProperty SystemButtonCloseOverColorProperty =
            DependencyProperty.Register("SystemButtonCloseOverColor", typeof(Brush), typeof(SinkawaMasterWindow), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(255, 0, 0))));

        #endregion

        #region 窗口属性
        /// <summary>
        /// 标题栏高度
        /// </summary>
        public double CaptionHeight
        {
            get { return (double)GetValue(CaptionHeightProperty); }
            set { SetValue(CaptionHeightProperty, value); }
        }
        public static readonly DependencyProperty CaptionHeightProperty =
            DependencyProperty.Register("CaptionHeight", typeof(double), typeof(SinkawaMasterWindow), new PropertyMetadata(30.0));

        /// <summary>
        /// 标题栏背景色
        /// </summary>
        public Brush CaptionBackground
        {
            get { return (Brush)GetValue(CaptionBackgroundProperty); }
            set { SetValue(CaptionBackgroundProperty, value); }
        }
        public static readonly DependencyProperty CaptionBackgroundProperty =
            DependencyProperty.Register("CaptionBackground", typeof(Brush), typeof(SinkawaMasterWindow), new PropertyMetadata(default));

        /// <summary>
        /// 标题栏的内容
        /// </summary>
        public UIElement TitleContent
        {
            get { return (UIElement)GetValue(TitleContentProperty); }
            set { SetValue(TitleContentProperty, value); }
        }
        public static readonly DependencyProperty TitleContentProperty =
            DependencyProperty.Register("TitleContent", typeof(UIElement), typeof(SinkawaMasterWindow), new PropertyMetadata(default));

        /// <summary>
        /// 沉浸式标题栏
        /// </summary>
        public bool FitSystemWindow
        {
            get { return (bool)GetValue(FitSystemWindowProperty); }
            set { SetValue(FitSystemWindowProperty, value); }
        }
        public static readonly DependencyProperty FitSystemWindowProperty =
            DependencyProperty.Register("FitSystemWindow", typeof(bool), typeof(SinkawaMasterWindow), new PropertyMetadata(default));


        #endregion

    }
}

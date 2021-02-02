using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Interop;
using DesktopClock;
using DesktopClock.MiscClasses;
using System.Windows.Markup;

namespace DesktopClock.OtherWindows
{
    /// <summary>
    /// TestWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainMenu : Window
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="owner">获取的父窗口</param>
        public MainMenu(Window owner)
        {
            Owner = owner;
            InitializeComponent();
            //设置初始位置
            InitializeThumbs();
            
        }

        /// <summary>
        /// 设置初始位置
        /// </summary>
        private void InitializeThumbs()
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            //设置SizeThumb的初始位置
            Canvas.SetLeft(SizeThumb, ((200 * (dcMainWindow.DcMainGrid.Height - 50)) / SystemParameters.WorkArea.Height) - 3);
            //设置CornerThumb的初始位置
            string mbCornerRadius = dcMainWindow.MainBackground.CornerRadius.ToString();
            string[] allCorners = mbCornerRadius.Split(',');
            Canvas.SetLeft(CornerThumb, (200 * double.Parse(allCorners[0]) / dcMainWindow.DcMainGrid.Height) - 3);
            ////设置全屏按键初始状态
            //if (dcMainWindow.WindowState == WindowState.Normal)
            //{
            //    WindowStateCheckBox.IsChecked = false;
            //    StateChangeToNormal();
            //}
            //else
            //{
            //    WindowStateCheckBox.IsChecked = true;
            //    StateChangeToMaximized();
            //}
            //设置字体ComboBox的初始selector
            FontComboBox.SelectedItem = dcMainWindow.Time.FontFamily.ToString();
            //设置时间格式的初始选择状态
            if (DcMainWindow.TimeFormat == "T")
            {
                TimeFormat_hms.IsChecked = true;
            }
            else
            {
                TimeFormat_hm.IsChecked = true;
            }
            //设置日期格式的初始选择状态
            if (DcMainWindow.DateFormat == "D")
            {
                DateFormat_ymd1.IsChecked = true;
            }
            else if (DcMainWindow.DateFormat == "d")
            {
                DateFormat_ymd2.IsChecked = true;
            }
            else
            {
                DateFormat_ymd3.IsChecked = true;
            }
            //设置星期格式的初始选择状态
            if (DcMainWindow.WeekFormat == "dddd")
            {
                WeekFormat_l.IsChecked = true;
            }
            else
            {
                WeekFormat_s.IsChecked = true;
            }
        }

        /// <summary>
        /// 窗体拖拽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseMainMenu_Click(object sender, RoutedEventArgs e)
        {
            CancelSettingsChange_Click(sender, e);          //关闭前进行一次取消设置
            DcMainWindow.isMainMenuShow = false;
            Close();
        }

        /// <summary>
        /// 保存设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSettingsChange_Click(object sender, RoutedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            //将更改后的值传给settings
            DesktopClockSettings.Default.WindowSize_height = dcMainWindow.DcMainGrid.Height;            //大小
            string mbCornerRadius = dcMainWindow.MainBackground.CornerRadius.ToString();                //获取边角弧度
            string[] allCorners = mbCornerRadius.Split(',');
            DesktopClockSettings.Default.WindowCorner = double.Parse(allCorners[0]);                    //边角弧度保存
            //DesktopClockSettings.Default.WindowState = (int)dcMainWindow.WindowState;                 //是否全屏
            DesktopClockSettings.Default.WindowFontFamily = dcMainWindow.Time.FontFamily.ToString();    //字体
            DesktopClockSettings.Default.TimeFormat = DcMainWindow.TimeFormat;                          //时间格式
            DesktopClockSettings.Default.DateFormat = DcMainWindow.DateFormat;                          //日期格式
            DesktopClockSettings.Default.WeekFormat = DcMainWindow.WeekFormat;                          //星期格式

            //保存更改
            DesktopClockSettings.Default.Save();
        }
        /// <summary>
        /// 取消设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSettingsChange_Click(object sender, RoutedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            dcMainWindow.LoadSettings();
            //恢复之前界面状态
            InitializeThumbs();
        }
        /// <summary>
        /// 重置设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetSettings_Click(object sender, RoutedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            //重置高度
            dcMainWindow.DcMainGrid.Height = 180;
            DesktopClockSettings.Default.WindowSize_height = 180;
            //重置边角半径
            dcMainWindow.MainBackground.CornerRadius = new CornerRadius(0);
            DesktopClockSettings.Default.WindowCorner = 0;
            ////重置窗口状态
            //Application.Current.MainWindow.WindowState = (WindowState)0;
            //StateChangeToNormal();
            //重置字体
            dcMainWindow.Time.FontFamily = new FontFamily("Microsoft YaHei UI");
            DesktopClockSettings.Default.WindowFontFamily = "Microsoft YaHei UI";
            //重置时间格式
            DcMainWindow.TimeFormat = "T";
            DesktopClockSettings.Default.TimeFormat = DcMainWindow.TimeFormat;
            //重置日期格式
            DcMainWindow.DateFormat = "D";
            DesktopClockSettings.Default.DateFormat = DcMainWindow.DateFormat;
            //重置星期格式
            DcMainWindow.WeekFormat = "dddd";
            DesktopClockSettings.Default.WeekFormat = DcMainWindow.WeekFormat;

            DesktopClockSettings.Default.Save();
        }

        /// <summary>
        /// 设置界面的滑块的移动方式
        /// </summary>
        /// <param name="thumb">滑块</param>
        /// <param name="e">事件对象</param>
        /// <param name="lBorder">左边界</param>
        /// <param name="rBorder">右边界</param>
        private void OptionThumbDrug(Thumb thumb, DragDeltaEventArgs e, double lBorder, double rBorder)
        {
            double x = Canvas.GetLeft(thumb);
            Canvas.SetLeft(thumb, x + e.HorizontalChange);      //令thumb跟随鼠标移动
            if (x < lBorder)
            {
                thumb.CancelDrag();             //删除thumb的鼠标捕获并触发DragComplete事件
                Canvas.SetLeft(thumb, lBorder); //防止thumb停在界外，下同
            }
            if (x > rBorder)
            {
                thumb.CancelDrag();
                Canvas.SetLeft(thumb, rBorder);
            }
        }

        private void SizeThumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            OptionThumbDrug(SizeThumb, e, -3.0, 197.0);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(SizeThumb) >= -3)
            {
                dcMainWindow.DcMainGrid.Height                                              //获得SizeThumb的Left转换给DcMainGrid的Height
                    = (((Canvas.GetLeft(SizeThumb) + 3) * SystemParameters.WorkArea.Height) / 200) + 50.0;
                //y_1 - 50 = k_1 * (x_1 + 3), k_1 = SystemParameters.WorkArea.Height / 200
                dcMainWindow.MainBackground.CornerRadius                                    //获得CornerThumb的Left转换给MainBackground的CornerRadius
                    = new CornerRadius(((Canvas.GetLeft(CornerThumb) + 3.0) * dcMainWindow.DcMainGrid.Height) / 200.0);
                //y_2 = k_2 * (x_2 + 3), k_2 = y_2 / 200
            }
        }

        private void CornerThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            OptionThumbDrug(CornerThumb, e, -3.0, 197.0);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(CornerThumb) >= -3)
            {
                dcMainWindow.MainBackground.CornerRadius                                                //获得CornerThumb的Left转换给MainBackground的CornerRadius
                    = new CornerRadius(((Canvas.GetLeft(CornerThumb) + 3.0) * dcMainWindow.DcMainGrid.Height) / 200.0);
                //y_2 = k_2 * (x_2 + 3), k_2 = y_2 / 200
            }
        }

        /// <summary>
        /// 读取字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (FontFamily fontfamily in Fonts.SystemFontFamilies)
            {
                LanguageSpecificStringDictionary fontdics = fontfamily.FamilyNames;
                //判断该字体是不是中文字体
                if (fontdics.ContainsKey(XmlLanguage.GetLanguage("zh-cn")))
                {
                    string fontfamilyname = null;
                    if (fontdics.TryGetValue(XmlLanguage.GetLanguage("zh-cn"), out fontfamilyname))
                    {
                        FontComboBox.Items.Add(fontfamilyname);
                    }
                }
                else
                {
                    string fontfamilyname = null;
                    if (fontdics.TryGetValue(XmlLanguage.GetLanguage("en-us"), out fontfamilyname))
                    {
                        FontComboBox.Items.Add(fontfamilyname);
                    }
                }
            }
        }

        private void FontComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            dcMainWindow.Time.FontFamily = new FontFamily(FontComboBox.SelectedItem.ToString());                                         //设置显示的字体
        }

        /// <summary>
        /// 选中后设置时间格式为h:m:s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeFormat_hms_Checked(object sender, RoutedEventArgs e)
        {
            DcMainWindow.TimeFormat = "T";
        }
        /// <summary>
        /// 选中后设置时间格式为h:m
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeFormat_hm_Checked(object sender, RoutedEventArgs e)
        {
            DcMainWindow.TimeFormat = "t";
        }
        /// <summary>
        /// 选中后设置日期格式为y年m月d日
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateFormat_ymd1_Checked(object sender, RoutedEventArgs e)
        {
            DcMainWindow.DateFormat = "D";
        }
        /// <summary>
        /// 选中后设置日期格式为y/m/d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateFormat_ymd2_Checked(object sender, RoutedEventArgs e)
        {
            DcMainWindow.DateFormat = "d";
        }
        /// <summary>
        /// 选中后设置日期格式为y.m.d
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateFormat_ymd3_Checked(object sender, RoutedEventArgs e)
        {
            DcMainWindow.DateFormat = "yyy.M.d";
        }
        /// <summary>
        /// 选中后设置星期格式为星期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeekFormat_l_Checked(object sender, RoutedEventArgs e)
        {
            DcMainWindow.WeekFormat = "dddd";
        }
        /// <summary>
        /// 选中后设置星期格式为周
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeekFormat_s_Checked(object sender, RoutedEventArgs e)
        {
            DcMainWindow.WeekFormat = "ddd";
        }

        ////CheckBox
        //private void WindowStateCheckBox_Checked(object sender, RoutedEventArgs e)
        //{
        //    StateChangeToMaximized();
        //    Application.Current.MainWindow.WindowState = (WindowState)2;         //使窗口全屏
        //}

        //private void WindowStateCheckBox_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    StateChangeToNormal();
        //    Application.Current.MainWindow.WindowState = (WindowState)0;         //窗口化
        //}
        ///// <summary>
        ///// 全屏后的更改项
        ///// </summary>
        //private void StateChangeToMaximized()
        //{
        //    DcMainWindow dcMainWindow = Owner as DcMainWindow;
        //    //透明度减半
        //    SizeLabel.Opacity = SizeThumb.Opacity = SizeThumbScope.Opacity = 0.5;
        //    CornerLabel.Opacity = CornerThumb.Opacity = CornerThumbScope.Opacity = 0.5;
        //    //鼠标穿透
        //    SizeThumb.IsHitTestVisible = false;
        //    CornerThumb.IsHitTestVisible = false;
        //    //将MainWindow的高设为1080
        //    double y = SystemParameters.WorkArea.Height;
        //    dcMainWindow.DcMainGrid.Height = y;
        //}
        ///// <summary>
        ///// 窗口化后的更改
        ///// </summary>
        //private void StateChangeToNormal()
        //{
        //    DcMainWindow dcMainWindow = Owner as DcMainWindow;
        //    //透明度恢复
        //    SizeLabel.Opacity = SizeThumb.Opacity = SizeThumbScope.Opacity = 1.0;
        //    CornerLabel.Opacity = CornerThumb.Opacity = CornerThumbScope.Opacity = 1.0;
        //    //取消鼠标穿透
        //    SizeThumb.IsHitTestVisible = true;
        //    CornerThumb.IsHitTestVisible = true;
        //    //将MainWindow的高设SizeThumb转换值
        //    dcMainWindow.DcMainGrid.Height = 4.0 * Canvas.GetLeft(SizeThumb) + 62.0;
        //}
    }
}

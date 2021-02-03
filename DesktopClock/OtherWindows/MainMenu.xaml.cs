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
        /// 用于修复一个因TextBox初始化时全为0导致的显示的bug，此bug为TextBox设计版的默认值引起，因此在加载后进行一次取消设置操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            dcMainWindow.LoadSettings();
            //恢复之前界面状态
            InitializeThumbs();
        }

        /// <summary>
        /// 设置初始位置
        /// </summary>
        private void InitializeThumbs()
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            //设置SizeThumb的初始位置
            Canvas.SetLeft(SizeThumb, ((200.0 * (dcMainWindow.DcMainGrid.Height - 50.0)) / SystemParameters.WorkArea.Height) - 3.0);
            //设置CornerThumb的初始位置
            string mbCornerRadius = dcMainWindow.MainBackground.CornerRadius.ToString();
            string[] allCorners = mbCornerRadius.Split(',');
            Canvas.SetLeft(CornerThumb, (200.0 * double.Parse(allCorners[0]) / dcMainWindow.DcMainGrid.Height) - 3.0);
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
            //设置前景色滑块的初始位置
            Canvas.SetLeft(ForegroundHueThumb, ((5.0 * DcMainWindow.ForegroundHue) / 9.0) - 3);
            Canvas.SetLeft(ForegroundSaturationThumb, (200.0 * DcMainWindow.ForegroundSaturation) - 3);
            Canvas.SetLeft(ForegroundBrightnessThumb, (200.0 * DcMainWindow.ForegroundBrightness) - 3);
            Canvas.SetLeft(ForegroundAlphaThumb, (200.0 * DcMainWindow.ForegroundAlpha) - 3);
            //设置背景色滑块的初始位置
            Canvas.SetLeft(BackgroundHueThumb, ((5.0 * DcMainWindow.BackgroundHue) / 9.0) - 3);
            Canvas.SetLeft(BackgroundSaturationThumb, (200.0 * DcMainWindow.BackgroundSaturation) - 3);
            Canvas.SetLeft(BackgroundBrightnessThumb, (200.0 * DcMainWindow.BackgroundBrightness) - 3);
            Canvas.SetLeft(BackgroundAlphaThumb, (200.0 * DcMainWindow.BackgroundAlpha) - 3);
            //设置SaturationThumb初始渐变色
            GradientStopColorControl(ForegroundSaturationGradientStop, ForegroundHueThumb);
            GradientStopColorControl(BackgroundSaturationGradientStop, BackgroundHueThumb);
            //设置TextBoxes的初始值
            ForegroundHueTextBox.Text = ((int)DcMainWindow.ForegroundHue).ToString();
            ForegroundSaturationTextBox.Text = ((int)(DcMainWindow.ForegroundSaturation * 100.0)).ToString();
            ForegroundBrightnessTextBox.Text = ((int)(DcMainWindow.ForegroundBrightness * 100.0)).ToString();
            ForegroundAlphaTextBox.Text = ((int)(DcMainWindow.ForegroundAlpha * 100.0)).ToString();
            BackgroundHueTextBox.Text = ((int)DcMainWindow.BackgroundHue).ToString();
            BackgroundSaturationTextBox.Text = ((int)(DcMainWindow.BackgroundSaturation * 100.0)).ToString();
            BackgroundBrightnessTextBox.Text = ((int)(DcMainWindow.BackgroundBrightness * 100.0)).ToString();
            BackgroundAlphaTextBox.Text = ((int)(DcMainWindow.BackgroundAlpha * 100.0)).ToString();
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

            GC.Collect();
            GC.SuppressFinalize(this);
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
            DesktopClockSettings.Default.WindowFontFamily = dcMainWindow.Time.FontFamily.ToString();    //字体
            DesktopClockSettings.Default.TimeFormat = DcMainWindow.TimeFormat;                          //时间格式
            DesktopClockSettings.Default.DateFormat = DcMainWindow.DateFormat;                          //日期格式
            DesktopClockSettings.Default.WeekFormat = DcMainWindow.WeekFormat;                          //星期格式
            //前景色
            DesktopClockSettings.Default.ForegroundHue = DcMainWindow.ForegroundHue;
            DesktopClockSettings.Default.ForegroundSaturation = DcMainWindow.ForegroundSaturation;
            DesktopClockSettings.Default.ForegroundBrightness = DcMainWindow.ForegroundBrightness;
            DesktopClockSettings.Default.ForegroundAlpha = DcMainWindow.ForegroundAlpha;
            //背景色
            DesktopClockSettings.Default.BackgroundHue = DcMainWindow.BackgroundHue;
            DesktopClockSettings.Default.BackgroundSaturation = DcMainWindow.BackgroundSaturation;
            DesktopClockSettings.Default.BackgroundBrightness = DcMainWindow.BackgroundBrightness;
            DesktopClockSettings.Default.BackgroundAlpha = DcMainWindow.BackgroundAlpha;

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
            dcMainWindow.DcMainGrid.Height = 180.0;
            DesktopClockSettings.Default.WindowSize_height = 180.0;
            //重置边角半径
            dcMainWindow.MainBackground.CornerRadius = new CornerRadius(0);
            DesktopClockSettings.Default.WindowCorner = 0.0;
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
            //重置前景色
            DcMainWindow.ForegroundHue = 0.0;
            DcMainWindow.ForegroundSaturation = 0.0;
            DcMainWindow.ForegroundBrightness = 1.0;
            DcMainWindow.ForegroundAlpha = 1.0;
            dcMainWindow.ChangeForegroundColor();
            DesktopClockSettings.Default.ForegroundHue = DcMainWindow.ForegroundHue;
            DesktopClockSettings.Default.ForegroundSaturation = DcMainWindow.ForegroundSaturation;
            DesktopClockSettings.Default.ForegroundBrightness = DcMainWindow.ForegroundBrightness;
            DesktopClockSettings.Default.ForegroundAlpha = DcMainWindow.ForegroundAlpha;
            //重置背景色
            DcMainWindow.BackgroundHue = 0.0;
            DcMainWindow.BackgroundSaturation = 0.0;
            DcMainWindow.BackgroundBrightness = 0.0;
            DcMainWindow.BackgroundAlpha = 0.0;
            dcMainWindow.ChangeBackgroundColor();
            DesktopClockSettings.Default.BackgroundHue = DcMainWindow.BackgroundHue;
            DesktopClockSettings.Default.BackgroundSaturation = DcMainWindow.BackgroundSaturation;
            DesktopClockSettings.Default.BackgroundBrightness = DcMainWindow.BackgroundBrightness;
            DesktopClockSettings.Default.BackgroundAlpha = DcMainWindow.BackgroundAlpha;

            //保存更改
            DesktopClockSettings.Default.Save();
            //重置后进行一次取消设置
            CancelSettingsChange_Click(sender, e);
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

        /// <summary>
        /// 大小滑块控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeThumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            OptionThumbDrug(SizeThumb, e, -3.0, 197.0);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(SizeThumb) >= -3.0 && Canvas.GetLeft(SizeThumb) <= 197.0)
            {
                dcMainWindow.DcMainGrid.Height                                              //获得SizeThumb的Left转换给DcMainGrid的Height
                    = (((Canvas.GetLeft(SizeThumb) + 3.0) * SystemParameters.WorkArea.Height) / 200.0) + 50.0;
                //y_1 - 50 = k_1 * (x_1 + 3), k_1 = SystemParameters.WorkArea.Height / 200
                dcMainWindow.MainBackground.CornerRadius                                    //获得CornerThumb的Left转换给MainBackground的CornerRadius
                    = new CornerRadius(((Canvas.GetLeft(CornerThumb) + 3.0) * dcMainWindow.DcMainGrid.Height) / 200.0);
                //y_2 = k_2 * (x_2 + 3), k_2 = y_2 / 200
            }
        }
        /// <summary>
        /// 边角弧度滑块控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CornerThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            OptionThumbDrug(CornerThumb, e, -3.0, 197.0);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(CornerThumb) >= -3.0 && Canvas.GetLeft(CornerThumb) <= 197.0)
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
                    if (fontdics.TryGetValue(XmlLanguage.GetLanguage("zh-cn"), out string fontfamilyname))
                    {
                        FontComboBox.Items.Add(fontfamilyname);
                    }
                }
                else
                {
                    if (fontdics.TryGetValue(XmlLanguage.GetLanguage("en-us"), out string fontfamilyname))
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

        /// <summary>
        /// SaturationThumb渐变色控制
        /// </summary>
        /// <param name="gradientStop">渐变色关键点</param>
        /// <param name="thumb">数据来源滑块</param>
        private void GradientStopColorControl(GradientStop gradientStop, Thumb thumb)
        {
            RGB_HSB.HSBToRGB(1.8 * (Canvas.GetLeft(thumb) + 3.0), 1.0, 1.0, out int r, out int g, out int b);
            gradientStop.Color = (Color)ColorConverter.ConvertFromString(RGB_HSB.ARGBToHex(1.0, r, g, b));
        }

        //前景色控制
        /// <summary>
        /// 前景色的H滑块控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForegroundHueThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            OptionThumbDrug(ForegroundHueThumb, e, -3, 197);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(ForegroundHueThumb) >= -3.0 && Canvas.GetLeft(ForegroundHueThumb) <= 197.0)
            {
                DcMainWindow.ForegroundHue = 1.8 * (Canvas.GetLeft(ForegroundHueThumb) + 3.0);
                dcMainWindow.ChangeForegroundColor();
                GradientStopColorControl(ForegroundSaturationGradientStop, ForegroundHueThumb);
                ForegroundHueTextBox.Text = ((int)DcMainWindow.ForegroundHue).ToString();
            }
        }
        /// <summary>
        /// 前景色的S滑块控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForegroundSaturationThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            OptionThumbDrug(ForegroundSaturationThumb, e, -3, 197);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(ForegroundSaturationThumb) >= -3.0 && Canvas.GetLeft(ForegroundSaturationThumb) <= 197.0)
            {
                DcMainWindow.ForegroundSaturation = 0.005 * (Canvas.GetLeft(ForegroundSaturationThumb) + 3.0);
                dcMainWindow.ChangeForegroundColor();
                ForegroundSaturationTextBox.Text = ((int)(DcMainWindow.ForegroundSaturation * 100.0)).ToString();
            }
        }
        /// <summary>
        /// 前景色的B滑块控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForegroundBrightnessThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            OptionThumbDrug(ForegroundBrightnessThumb, e, -3, 197);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(ForegroundBrightnessThumb) >= -3.0 && Canvas.GetLeft(ForegroundBrightnessThumb) <= 197.0)
            {
                DcMainWindow.ForegroundBrightness = 0.005 * (Canvas.GetLeft(ForegroundBrightnessThumb) + 3.0);
                dcMainWindow.ChangeForegroundColor();
                ForegroundBrightnessTextBox.Text = ((int)(DcMainWindow.ForegroundBrightness * 100.0)).ToString();
            }
        }
        /// <summary>
        /// 前景色的A滑块控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForegroundAlphaThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            OptionThumbDrug(ForegroundAlphaThumb, e, -3, 197);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(ForegroundAlphaThumb) >= -3.0 && Canvas.GetLeft(ForegroundAlphaThumb) <= 197.0)
            {
                DcMainWindow.ForegroundAlpha = 0.005 * (Canvas.GetLeft(ForegroundAlphaThumb) + 3.0);
                dcMainWindow.ChangeForegroundColor();
                ForegroundAlphaTextBox.Text = ((int)(DcMainWindow.ForegroundAlpha * 100.0)).ToString();
            }
        }
        //背景色控制
        /// <summary>
        /// 背景色的H滑块控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundHueThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            OptionThumbDrug(BackgroundHueThumb, e, -3, 197);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(BackgroundHueThumb) >= -3.0 && Canvas.GetLeft(BackgroundHueThumb) <= 197.0)
            {
                DcMainWindow.BackgroundHue = 1.8 * (Canvas.GetLeft(BackgroundHueThumb) + 3.0);
                dcMainWindow.ChangeBackgroundColor();
                GradientStopColorControl(BackgroundSaturationGradientStop, BackgroundHueThumb);
                BackgroundHueTextBox.Text = ((int)DcMainWindow.BackgroundHue).ToString();
            }
        }
        /// <summary>
        /// 背景色的S滑块控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundSaturationThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            OptionThumbDrug(BackgroundSaturationThumb, e, -3, 197);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(BackgroundSaturationThumb) >= -3.0 && Canvas.GetLeft(BackgroundSaturationThumb) <= 197.0)
            {
                DcMainWindow.BackgroundSaturation = 0.005 * (Canvas.GetLeft(BackgroundSaturationThumb) + 3.0);
                dcMainWindow.ChangeBackgroundColor();
                BackgroundSaturationTextBox.Text = ((int)(DcMainWindow.BackgroundSaturation * 100.0)).ToString();
            }
        }
        /// <summary>
        /// 背景色的B滑块控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundBrightnessThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            OptionThumbDrug(BackgroundBrightnessThumb, e, -3, 197);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(BackgroundBrightnessThumb) >= -3.0 && Canvas.GetLeft(BackgroundBrightnessThumb) <= 197.0)
            {
                DcMainWindow.BackgroundBrightness = 0.005 * (Canvas.GetLeft(BackgroundBrightnessThumb) + 3.0);
                dcMainWindow.ChangeBackgroundColor();
                BackgroundBrightnessTextBox.Text = ((int)(DcMainWindow.BackgroundBrightness * 100.0)).ToString();
            }
        }
        /// <summary>
        /// 背景色的A滑块控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundAlphaThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            OptionThumbDrug(BackgroundAlphaThumb, e, -3, 197);
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            if (Canvas.GetLeft(BackgroundAlphaThumb) >= -3.0 && Canvas.GetLeft(BackgroundAlphaThumb) <= 197.0)
            {
                DcMainWindow.BackgroundAlpha = 0.005 * (Canvas.GetLeft(BackgroundAlphaThumb) + 3.0);
                dcMainWindow.ChangeBackgroundColor();
                BackgroundAlphaTextBox.Text = ((int)(DcMainWindow.BackgroundAlpha * 100.0)).ToString();
            }
        }

        //前景色的输入取色功能
        /// <summary>
        /// 前景色H输入取色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForegroundHueTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            double.TryParse(ForegroundHueTextBox.Text, out double text);
            if (text < 0.0)
            {
                text = 0.0;
            }
            else if (text > 360.0)
            {
                text = 360.0;
            }
            ForegroundHueTextBox.Text = text.ToString();
            DcMainWindow.ForegroundHue = text;
            dcMainWindow.ChangeForegroundColor();
            Canvas.SetLeft(ForegroundHueThumb, ((5.0 * DcMainWindow.ForegroundHue) / 9.0) - 3);
        }
        /// <summary>
        /// 前景色S输入取色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForegroundSaturationTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            double.TryParse(ForegroundSaturationTextBox.Text, out double text);
            if (text < 0.0)
            {
                text = 0.0;
            }
            else if (text > 100.0)
            {
                text = 100.0;
            }
            ForegroundSaturationTextBox.Text = text.ToString();
            DcMainWindow.ForegroundSaturation = text / 100.0;
            dcMainWindow.ChangeForegroundColor();
            Canvas.SetLeft(ForegroundSaturationThumb, (200.0 * DcMainWindow.ForegroundSaturation) - 3);
        }
        /// <summary>
        /// 前景色B输入取色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForegroundBrightnessTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            double.TryParse(ForegroundBrightnessTextBox.Text, out double text);
            if (text < 0.0)
            {
                text = 0.0;
            }
            else if (text > 100.0)
            {
                text = 100.0;
            }
            ForegroundBrightnessTextBox.Text = text.ToString();
            DcMainWindow.ForegroundBrightness = text / 100.0;
            dcMainWindow.ChangeForegroundColor();
            Canvas.SetLeft(ForegroundBrightnessThumb, (200.0 * DcMainWindow.ForegroundBrightness) - 3);
        }
        /// <summary>
        /// 前景色A输入取色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForegroundAlphaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            double.TryParse(ForegroundAlphaTextBox.Text, out double text);
            if (text < 0.0)
            {
                text = 0.0;
            }
            else if (text > 100.0)
            {
                text = 100.0;
            }
            ForegroundAlphaTextBox.Text = text.ToString();
            DcMainWindow.ForegroundAlpha = text / 100.0;
            dcMainWindow.ChangeForegroundColor();
            Canvas.SetLeft(ForegroundAlphaThumb, (200.0 * DcMainWindow.ForegroundAlpha) - 3);
        }
        //背景色的输入取色功能
        /// <summary>
        /// 背景色H输入取色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundHueTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            double.TryParse(BackgroundHueTextBox.Text, out double text);
            if (text < 0.0)
            {
                text = 0.0;
            }
            else if (text > 360.0)
            {
                text = 360.0;
            }
            BackgroundHueTextBox.Text = text.ToString();
            DcMainWindow.BackgroundHue = text;
            dcMainWindow.ChangeBackgroundColor();
            Canvas.SetLeft(BackgroundHueThumb, ((5.0 * DcMainWindow.BackgroundHue) / 9.0) - 3);
        }
        /// <summary>
        /// 背景色S输入取色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundSaturationTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            double.TryParse(BackgroundSaturationTextBox.Text, out double text);
            if (text < 0.0)
            {
                text = 0.0;
            }
            else if (text > 100.0)
            {
                text = 100.0;
            }
            BackgroundSaturationTextBox.Text = text.ToString();
            DcMainWindow.BackgroundSaturation = text / 100.0;
            dcMainWindow.ChangeBackgroundColor();
            Canvas.SetLeft(BackgroundSaturationThumb, (200.0 * DcMainWindow.BackgroundSaturation) - 3);
        }
        /// <summary>
        /// 背景色B输入取色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundBrightnessTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            double.TryParse(BackgroundBrightnessTextBox.Text, out double text);
            if (text < 0.0)
            {
                text = 0.0;
            }
            else if (text > 100.0)
            {
                text = 100.0;
            }
            BackgroundBrightnessTextBox.Text = text.ToString();
            DcMainWindow.BackgroundBrightness = text / 100.0;
            dcMainWindow.ChangeBackgroundColor();
            Canvas.SetLeft(BackgroundBrightnessThumb, (200.0 * DcMainWindow.BackgroundBrightness) - 3);
        }
        /// <summary>
        /// 背景色A输入取色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundAlphaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DcMainWindow dcMainWindow = Owner as DcMainWindow;
            double.TryParse(BackgroundAlphaTextBox.Text, out double text);
            if (text < 0.0)
            {
                text = 0.0;
            }
            else if (text > 100.0)
            {
                text = 100.0;
            }
            BackgroundAlphaTextBox.Text = text.ToString();
            DcMainWindow.BackgroundAlpha = text / 100.0;
            dcMainWindow.ChangeBackgroundColor();
            Canvas.SetLeft(BackgroundAlphaThumb, (200.0 * DcMainWindow.BackgroundAlpha) - 3);
        }
    }
}

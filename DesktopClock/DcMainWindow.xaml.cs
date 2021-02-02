using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Runtime.InteropServices; //DllImport
using System.Windows.Interop;
using Microsoft.Win32;
using System.Windows.Media.Animation;
using DesktopClock.OtherWindows;

namespace DesktopClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DcMainWindow : Window
    {
        /// <summary>
        /// 计时器
        /// </summary>
        private readonly DispatcherTimer ShowTimer;

        /// <summary>
        /// 锁定状态，true为已锁定
        /// </summary>
        public static bool isLocked = false;
        /// <summary>
        /// 选项菜单打开状态，true为已打开
        /// </summary>
        public static bool isMainMenuShow = false;      //控制菜单是否可以打开
        /// <summary>
        /// 设置按钮打开状态，true为已打开
        /// </summary>
        public static bool isOptionOpen = false;

        /// <summary>
        /// 时间显示格式
        /// </summary>
        public static string TimeFormat;
        /// <summary>
        /// 日期显示格式
        /// </summary>
        public static string DateFormat;
        /// <summary>
        /// 星期显示格式
        /// </summary>
        public static string WeekFormat;
        
        public DcMainWindow()
        {
            InitializeComponent();
            //计时器主体
            ShowTime();
            ShowTimer = new DispatcherTimer();
            ShowTimer.Tick += new EventHandler(ShowCurTimer);       //在计时器触发器上挂载ShowCurTim
            ShowTimer.Interval = new TimeSpan(0, 0, 0, 0, 50);      //设置计时器间隔为50毫秒
            ShowTimer.Start();

            
        }

        private void dcMainWindow_Initialized(object sender, EventArgs e)
        {
            //初始化
            LoadSettings();
        }
        /// <summary>
        /// 加载设置
        /// </summary>
        public void LoadSettings()
        {
            DcMainGrid.Height = DesktopClockSettings.Default.WindowSize_height;                             //大小
            MainBackground.CornerRadius = new CornerRadius(DesktopClockSettings.Default.WindowCorner);      //边角半径
            //WindowState = (WindowState)DesktopClockSettings.Default.WindowState;                          //是否全屏
            Time.FontFamily = new FontFamily(DesktopClockSettings.Default.WindowFontFamily.ToString());     //设置字体
            TimeFormat = DesktopClockSettings.Default.TimeFormat;                                           //时间显示格式
            DateFormat = DesktopClockSettings.Default.DateFormat;                                           //日期显示格式
            WeekFormat = DesktopClockSettings.Default.WeekFormat;                                           //星期显示格式
        }

        private void MainBackground_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //未上锁时可以拖动DesktopClock
            if (!isLocked)
            {
                DragMove();
            }
        }

        private void MainBackground_MouseEnter(object sender, MouseEventArgs e)
        {
            //鼠标进入时令LockButton显现为锁住模式
            if(isLocked)
            {
                LockButton.Visibility = Visibility.Visible;
            }
            else
            {
                MainBackground.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3FFFFFFF"));        //鼠标进入时显示边框
            }
        }

        private void MainBackground_MouseLeave(object sender, MouseEventArgs e)
        {
            //鼠标离开时令LockButton完全透明
            if (isLocked)
            {
                LockButton.Visibility = Visibility.Hidden;
            }
            MainBackground.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#01FFFFFF"));        //鼠标离开后隐藏边框
        }

        private void MainBackground_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            //锁住右键菜单
            if (isLocked)
            {
                e.Handled = true;       //将事件标记为已处理
            }
        }
        /// <summary>
        /// ShowTime
        /// </summary>
        private void ShowTime()
        {
            //获得年月日
            Date.Content = DateTime.Now.ToString(DateFormat);      //————年——月——日
            //获得时分秒
            Time.Content = DateTime.Now.ToString(TimeFormat);      //..:..:..
            //获得星期
            Week.Content = DateTime.Now.ToString(WeekFormat);   //星期几
        }
        /// <summary>
        /// 显示当前时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowCurTimer(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void LockButton_Click(object sender, RoutedEventArgs e)
        {
            isLocked = !isLocked;       //反转isLocked
            //若锁住，则令LockButton为锁住状态，否则为未锁状态
            if (isLocked)
            {
                LockButton.ToolTip = "解锁";
                LockButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#01000000"));
                LockButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3FFFFFFF"));
                EasyAppearAnimation(1.0, 0.0, 500, Options, "Opacity");     //隐藏选项按钮Opacity
                if (isOptionOpen)
                {
                    Options_Click(Options, e);
                }
                MainBackground.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#01FFFFFF"));        //锁定后隐藏边框
            }
            else
            {
                LockButton.ToolTip = "锁定";
                LockButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#01000000"));
                LockButton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7FFFFFFF"));
                EasyAppearAnimation(0.0, 1.0, 500, Options, "Opacity");    //显示选项按钮
                MainBackground.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3FFFFFFF"));        //解锁后显示边框
            }
        }


        //引入Windows API
        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public const UInt32 SWP_NOSIZE = 0x0001;
        public const UInt32 SWP_NOMOVE = 0x0002;
        public const UInt32 SWP_NOACTIVATE = 0x0010;
        public static readonly IntPtr HWND_BOTTOM = new IntPtr(1);

        /// <summary>
        /// 将窗口置于底层
        /// </summary>
        /// <param name="window">要置底的窗口</param>
        private void SetBottom(Window window)
        {
            IntPtr hWnd = new WindowInteropHelper(window).Handle;
            SetWindowPos(hWnd, HWND_BOTTOM, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOACTIVATE);
        }

        private void mainWindow_StateChanged(object sender, EventArgs e)
        {
            SetBottom(dcMainWindow);
        }

        private void mainWindow_Activated(object sender, EventArgs e)
        {
            SetBottom(dcMainWindow);
        }

        private void MainBackground_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SetBottom(dcMainWindow);
        }

        //⚙
        private void Options_Click(object sender, RoutedEventArgs e)
        {
            if (!isOptionOpen)
            {
                EasyRotateAnimation(0.0, 180.0, 300, OptionsRotateTransform);
                EasyAppearAnimation(0.0, 100.0, 300, OptionsContent, "Width");
            }
            else
            {
                EasyRotateAnimation(180, 0.0, 300, OptionsRotateTransform);
                EasyAppearAnimation(100.0, 0.0, 300, OptionsContent, "Width");
            }
            isOptionOpen = !isOptionOpen;
        }
        private void OptionsShutdown_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        private void OptionsOpenMainMenu_Click(object sender, RoutedEventArgs e)
        {
            if (!isMainMenuShow)
            {
                var mainMenu = new MainMenu(Application.Current.MainWindow);
                isMainMenuShow = true;
                mainMenu.Show();
            }
        }
        /// <summary>
        /// 简单旋转动画
        /// </summary>
        /// <param name="from">起始角度</param>
        /// <param name="to">结束角度</param>
        /// <param name="milliseconds">持续时间（毫秒）</param>
        /// <param name="name">动画目标</param>
        private void EasyRotateAnimation(double from, double to, int milliseconds, RotateTransform name)
        {
            Duration duration = new Duration(TimeSpan.FromMilliseconds(milliseconds));
            DoubleAnimation erAnimation = new DoubleAnimation
            {
                From = from,
                To = to,
                Duration = duration
            };
            name.BeginAnimation(RotateTransform.AngleProperty, erAnimation);
        }
        /// <summary>
        /// 简单出现过度动画
        /// </summary>
        /// <param name="from">开始属性</param>
        /// <param name="to">结束属性</param>
        /// <param name="milliseconds">持续时间</param>
        /// <param name="name">动画目标</param>
        private void EasyAppearAnimation(double from, double to, int milliseconds, DependencyObject name, string path)
        {
            Duration duration = new Duration(TimeSpan.FromMilliseconds(milliseconds));
            DoubleAnimation eaAnimation = new DoubleAnimation
            {
                From = from,
                To = to,
                Duration = duration,
            };
            Storyboard.SetTarget(eaAnimation, name);
            Storyboard.SetTargetProperty(eaAnimation, new PropertyPath(path));
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(eaAnimation);
            storyboard.Begin();
        }

        private void DcMainGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (DcMainGrid.Height < 75)
            {
                if (isOptionOpen)
                {
                    Options_Click(Options, e);
                }
                Options.Visibility = Visibility.Hidden;     //隐藏选项按钮Opacity
            }
            else
            {
                Options.Visibility = Visibility.Visible;
            }
        }


    }
}

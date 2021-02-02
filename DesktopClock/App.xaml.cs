using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using DesktopClock.OtherWindows;

namespace DesktopClock
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            
        }


        private void MiClose_Click(object sender, RoutedEventArgs e)
        {
            Current.Shutdown();
        }

        private void MiMenu_Click(object sender, RoutedEventArgs e)
        {
            if(!DcMainWindow.isMainMenuShow)
            {
                var mainMenu = new MainMenu(MainWindow);
                DcMainWindow.isMainMenuShow = true;
                mainMenu.Show();
            } 
        }

        private void MiTest_Click(object sender, RoutedEventArgs e)
        {
            var testWindow = new TestWindow();
            testWindow.Show();
        }


    }

}

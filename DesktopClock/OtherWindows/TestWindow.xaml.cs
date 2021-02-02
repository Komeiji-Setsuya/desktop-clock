using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesktopClock.OtherWindows
{
    /// <summary>
    /// TestWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {

        }

        private void CustomButton_Click(object sender, RoutedEventArgs e)
        {
            TestButton.FontFamily = new FontFamily(TestComboBox.SelectedItem.ToString());

        }

        private void TestComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            //foreach (FontFamily font in Fonts.SystemFontFamilies)
            //{
            //    TestComboBox.Items.Add(font.Source);
            //}

            foreach (FontFamily fontfamily in Fonts.SystemFontFamilies)
            {
                LanguageSpecificStringDictionary fontdics = fontfamily.FamilyNames;
                //判断该字体是不是中文字体
                if (fontdics.ContainsKey(XmlLanguage.GetLanguage("zh-cn")))
                {
                    string fontfamilyname = null;
                    if (fontdics.TryGetValue(XmlLanguage.GetLanguage("zh-cn"), out fontfamilyname))
                    {
                        TestComboBox.Items.Add(fontfamilyname);
                    }
                }
                else
                {
                    string fontfamilyname = null;
                    if (fontdics.TryGetValue(XmlLanguage.GetLanguage("en-us"), out fontfamilyname))
                    {
                        TestComboBox.Items.Add(fontfamilyname);
                    }
                }
            }

            TestComboBox.SelectedItem = new FontFamily("微软雅黑").ToString();
        }
    }
}

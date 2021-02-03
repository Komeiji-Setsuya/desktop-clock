using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DesktopClock.MiscClasses
{
    class RGB_HSB
    {
        //From:https://www.codeproject.com/Articles/19045/Manipulating-colors-in-NET-Part-1
        /// <summary>
        /// 10进制RGB转换为HSB
        /// </summary>
        /// <param name="red">0~255</param>
        /// <param name="green">0~255</param>
        /// <param name="blue">0~255</param>
        /// <param name="hue">0~360</param>
        /// <param name="sat">0~1</param>
        /// <param name="bri">0~1</param>
        public static void RGBToHSB(int red, int green, int blue, out double hue, out double sat, out double bri)
        {
            double r = ((double)red / 255.0);
            double g = ((double)green / 255.0);
            double b = ((double)blue / 255.0);

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            hue = 0.0;
            if (max == r && g >= b)
            {
                if (max - min == 0) hue = 0.0;
                else hue = 60 * (g - b) / (max - min);
            }
            else if (max == r && g < b)
            {
                hue = 60 * (g - b) / (max - min) + 360;
            }
            else if (max == g)
            {
                hue = 60 * (b - r) / (max - min) + 120;
            }
            else if (max == b)
            {
                hue = 60 * (r - g) / (max - min) + 240;
            }

            sat = (max == 0) ? 0.0 : (1.0 - ((double)min / (double)max));
            bri = max;
        }
        /// <summary>
        /// 10进制HSB转换为RGB
        /// </summary>
        /// <param name="hue">0~360</param>
        /// <param name="sat">0~1</param>
        /// <param name="bri">0~1</param>
        /// <param name="red">0~255</param>
        /// <param name="green">0~255</param>
        /// <param name="blue">0~255</param>
        public static void HSBToRGB(double hue, double sat, double bri, out int red, out int green, out int blue)
        {
            double r = 0;
            double g = 0;
            double b = 0;

            if (sat == 0)
            {
                r = g = b = bri;
            }
            else
            {
                if (hue == 360)
                {
                    hue = 0.0;
                }
                double sectorPos = hue / 60.0;
                int sectorNumber = (int)Math.Floor(sectorPos);
                double fractionalSector = sectorPos - sectorNumber;

                double p = bri * (1.0 - sat);
                double q = bri * (1.0 - (sat * fractionalSector));
                double t = bri * (1.0 - (sat * (1 - fractionalSector)));

                switch (sectorNumber)
                {
                    case 0:
                        r = bri;
                        g = t;
                        b = p;
                        break;
                    case 1:
                        r = q;
                        g = bri;
                        b = p;
                        break;
                    case 2:
                        r = p;
                        g = bri;
                        b = t;
                        break;
                    case 3:
                        r = p;
                        g = q;
                        b = bri;
                        break;
                    case 4:
                        r = t;
                        g = p;
                        b = bri;
                        break;
                    case 5:
                        r = bri;
                        g = p;
                        b = q;
                        break;
                }
            }
            red = Convert.ToInt32(r * 255);
            green = Convert.ToInt32(g * 255);
            blue = Convert.ToInt32(b * 255); ;
        }
        /// <summary>
        /// 将10进制rgb转换为16进制rgb字符串
        /// </summary>
        /// <param name="a">alpha</param>
        /// <param name="r">red</param>
        /// <param name="g">green</param>
        /// <param name="b">blue</param>
        /// <returns>#AARRGGBB</returns>
        public static string ARGBToHex(double a, int r, int g, int b)
        {
            return string.Format("#{0:x2}{1:x2}{2:x2}{3:x2}",(int)(a * 255) , r, g, b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Management;
using System.Runtime.InteropServices;

namespace Juqent.CPS.ScreenSplit
{
    /// <summary>
    /// 屏幕帮助类
    /// </summary>
    public static class ScreenHelper
    {
        /// <summary>
        /// 将窗体放在指定的屏幕上
        /// </summary>
        /// <param name="form"></param>
        /// <param name="showOnMonitor"></param>
        public static void SetScreen(Form form, int showOnMonitor)
        {
            Screen[] sc = Screen.AllScreens;
            if (showOnMonitor >= sc.Length)
            {
                showOnMonitor = 0;
            }
            form.StartPosition = FormStartPosition.Manual;
            int x = sc[showOnMonitor].Bounds.Left;
            int y = sc[showOnMonitor].Bounds.Top;
            form.Location = new Point(x, y);
        }

        /// <summary>
        /// 获取一块屏幕
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        public static Screen GetScreen(int index)
        {
            Screen[] sc = Screen.AllScreens;
            if (index >= sc.Length)
            {
                index = 0;
            }

            return sc[index];
        }

        /// <summary>
        /// 获取主屏
        /// </summary>
        /// <returns></returns>
        public static Screen GetPrimaryScreen()
        {
            Screen screen = null;
            Screen[] sc = Screen.AllScreens;
            if (sc.Length > 0)
            {
                foreach (Screen scn in sc)
                {
                    if (scn.Primary)
                    {
                        screen = scn;
                    }
                }
            }
            return screen;
        }

        /// <summary>
        /// 截屏
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static Bitmap CopyPrimaryScreen(Rectangle r)
        {
            int w = r.Width;
            int h = r.Height;
            Bitmap bmp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(new Point(r.X, r.Y), new Point(0, 0), new Size(w, h));
            return bmp;
        }

        /// <summary>
        ///改变图像大小
        /// </summary>
        /// <param name="imgToResize"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static System.Drawing.Image ResizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //获取图片宽度
            int sourceWidth = imgToResize.Width;
            //获取图片高度
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //计算宽度的缩放比例
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //计算高度的缩放比例
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //期望的宽度
            int destWidth = (int)(sourceWidth * nPercent);
            //期望的高度
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //绘制图像
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        /// <summary>
        /// 获取显卡信息
        /// </summary>
        /// <returns></returns>
        public static string GetCardInfo()
        {
            string message = string.Empty;
            ManagementObjectSearcher objvide = new ManagementObjectSearcher("select * from Win32_VideoController");
            foreach (ManagementObject obj in objvide.Get())
            {
                message += "Name - " + obj["Name"] + "\r\n";
                message += "DeviceID - " + obj["DeviceID"] + "\r\n";
                message += "AdapterRAM - " + obj["AdapterRAM"] + "\r\n";
                message += "AdapterDACType - " + obj["AdapterDACType"] + "\r\n";
                message += "Monochrome - " + obj["Monochrome"] + "\r\n";
                message += "InstalledDisplayDrivers - " + obj["InstalledDisplayDrivers"] + "\r\n";
                message += "DriverVersion - " + obj["DriverVersion"] + "\r\n";
                message += "VideoProcessor - " + obj["VideoProcessor"] + "\r\n";
                message += "VideoArchitecture - " + obj["VideoArchitecture"] + "\r\n";
                message += "VideoMemoryType - " + obj["VideoMemoryType"] + "\r\n\r\n\r\n";
            }
            return message;
        }

        // 改变分辨率
        public static string ChangeResolution(int width, int height, string deviceName)
        {
            string result = string.Empty;

            #region 初始化DEVMODE结构

            DEVMODE devmode = new DEVMODE();
            devmode.dmDeviceName = new String(new char[32]);
            devmode.dmFormName = new String(new char[32]);
            devmode.dmSize = (short)Marshal.SizeOf(devmode);

            #endregion

            #region
            if (0 != NativeMethods.EnumDisplaySettings(null, NativeMethods.ENUM_CURRENT_SETTINGS, ref devmode))
            {
                devmode.dmPelsWidth = width;
                devmode.dmPelsHeight = height;
                if (!string.IsNullOrEmpty(deviceName))
                {
                    devmode.dmDeviceName = deviceName;
                }

                // 改变屏幕分辨率
                int iRet = NativeMethods.ChangeDisplaySettings(ref devmode, NativeMethods.CDS_TEST);

                if (iRet == NativeMethods.DISP_CHANGE_FAILED)
                {
                    result = "不能执行你的请求";
                }
                else
                {
                    iRet = NativeMethods.ChangeDisplaySettings(ref devmode, NativeMethods.CDS_UPDATEREGISTRY);

                    switch (iRet)
                    {
                        // 成功改变
                        case NativeMethods.DISP_CHANGE_SUCCESSFUL:
                            break;
                        case NativeMethods.DISP_CHANGE_RESTART:
                            result = "你需要重新启动电脑设置才能生效";
                            break;
                        default:
                            result = "改变屏幕分辨率失败";
                            break;
                    }
                }
            }
            #endregion

            return result;
        }
    }

    /// 映射 DEVMODE 结构
    /// 可以参照 DEVMODE结构的指针定义：
    /// http://msdn.microsoft.com/en-us/library/windows/desktop/dd183565(v=vs.85).aspx
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DEVMODE
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;
        public short dmSpecVersion;
        public short dmDriverVersion;
        public short dmSize;
        public short dmDriverExtra;
        public int dmFields;
        public int dmPositionX;
        public int dmPositionY;
        public int dmDisplayOrientation;
        public int dmDisplayFixedOutput;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;
        public short dmLogPixels;
        public short dmBitsPerPel;
        public int dmPelsWidth;
        public int dmPelsHeight;
        public int dmDisplayFlags;
        public int dmDisplayFrequency;
        public int dmICMMethod;
        public int dmICMIntent;
        public int dmMediaType;
        public int dmDitherType;
        public int dmReserved1;
        public int dmReserved2;
        public int dmPanningWidth;
        public int dmPanningHeight;
    };

    // Win32 函数在托管环境下的声明
    public class NativeMethods
    {
        // 平台调用的申明
        [DllImport("user32.dll")]
        public static extern int EnumDisplaySettings(
          string deviceName, int modeNum, ref DEVMODE devMode);
        [DllImport("user32.dll")]
        public static extern int ChangeDisplaySettings(
              ref DEVMODE devMode, int flags);

        //控制改变屏幕分辨率的常量
        public const int ENUM_CURRENT_SETTINGS = -1;
        public const int CDS_UPDATEREGISTRY = 0x01;
        public const int CDS_TEST = 0x02;
        public const int DISP_CHANGE_SUCCESSFUL = 0;
        public const int DISP_CHANGE_RESTART = 1;
        public const int DISP_CHANGE_FAILED = -1;

        // 控制改变方向的常量定义
        public const int DMDO_DEFAULT = 0;
        public const int DMDO_90 = 1;
        public const int DMDO_180 = 2;
        public const int DMDO_270 = 3;
    }
}

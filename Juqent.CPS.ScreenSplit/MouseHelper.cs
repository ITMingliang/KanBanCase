using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Juqent.CPS.ScreenSplit
{
    /// <summary>
    /// 鼠标帮助类
    /// </summary>
    public static class MouseHelper
    {
        /// <summary>
        /// 引用user32.dll动态链接库（windows api）
        /// 使用库中定义 API：SetCursorPos 
        /// </summary>
        [DllImport("user32.dll")]
        private static extern int SetCursorPos(int x, int y);

        /// <summary>
        /// 移动鼠标到指定的坐标点
        /// </summary>
        public static void MoveMouseToPoint(Point p)
        {
            SetCursorPos(p.X, p.Y);
        }

        /// <summary>
        /// 设置鼠标的移动范围
        /// </summary>
        public static void SetMouseRectangle(Rectangle rectangle)
        {
            System.Windows.Forms.Cursor.Clip = rectangle;
        }

        /// <summary>
        /// 设置鼠标位于屏幕中心
        /// </summary>
        public static void SetMouseAtCenterScreen(Screen scn)
        {
            int x = scn.Bounds.X;
            int y = scn.Bounds.Y;
            int winHeight = scn.WorkingArea.Height;
            int winWidth = scn.WorkingArea.Width;
            Point centerP = new Point((winWidth / 2) + x, (winHeight / 2) + y);
            MoveMouseToPoint(centerP);
        }     
    }
}
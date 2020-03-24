using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;

namespace Summer.AutomationTest
{
    /// <summary>
    /// MouseExtension
    /// </summary>
    public static class MouseExtension
    {
        /// <summary>
        /// 鼠标左击
        /// </summary>
        /// <param name="automationElement">UI自动化元素</param>
        public static void MouseLeftClick(this AutomationElement automationElement)
        {
            Point centrePoint = automationElement.Current.BoundingRectangle.CentrePoint();

            //Make the cursor position to the element.
            UnsafeNativeMethods.SetCursorPos((int)centrePoint.X, (int)centrePoint.Y);

            //Make the left mouse down and up.
            UnsafeNativeMethods.mouse_event(UnsafeNativeMethods.MOUSEEVENTF_LEFTDOWN, (int)centrePoint.X, (int)centrePoint.Y, 0, UIntPtr.Zero);
            UnsafeNativeMethods.mouse_event(UnsafeNativeMethods.MOUSEEVENTF_LEFTUP, (int)centrePoint.X, (int)centrePoint.Y, 0, UIntPtr.Zero);
        }

        /// <summary>
        /// 矩形中心点
        /// </summary>
        /// <param name="rect">矩形</param>
        /// <returns>中心点</returns>
        public static Point CentrePoint(this Rect rect)
        {
            return new Point(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Summer.AutomationTest
{
    /// <summary>
    /// UnsafeNativeMethods
    /// </summary>
    internal static class UnsafeNativeMethods
    {
        #region 常量

        /// <summary>
        /// 
        /// </summary>
        public const int MOUSEEVENTF_MOVE = 0x0001;

        /// <summary>
        /// 
        /// </summary>
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;

        /// <summary>
        /// 
        /// </summary>
        public const int MOUSEEVENTF_LEFTUP = 0x0004;

        /// <summary>
        /// 
        /// </summary>
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;

        /// <summary>
        /// 
        /// </summary>
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;

        /// <summary>
        /// 
        /// </summary>
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;

        /// <summary>
        /// 
        /// </summary>
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;

        /// <summary>
        /// 
        /// </summary>
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        #endregion

        #region 方法

        /// <summary>
        /// Add mouse move event
        /// </summary>
        /// <param name="x">指定光标的新的X坐标，以屏幕坐标表示。</param>
        /// <param name="y">指定光标的新的Y坐标，以屏幕坐标表示。</param>
        /// <returns>如果成功，返回非零值；如果失败，返回值是零，若想获得更多错误信息，请调用GetLastError函数。</returns>
        [DllImport("user32.dll")]
        public extern static bool SetCursorPos(int x, int y);

        /// <summary>
        /// Mouse click event
        /// </summary>
        /// <param name="dwFlag">
        /// MOUSEEVENTF_ABSOLUTE dX和dY参数含有规范化的绝对坐标。如果不设置，这些参数含有相对数据：相对于上次位置的改动位置。此标志可设置，也可不设置，不管鼠标的类型或与系统相连的类似于鼠标的设备的类型如何。要得到关于相对鼠标动作的信息，参见下面备注部分。
        /// MOUSEEVENTF_MOVE 这表示鼠标移动
        /// MOUSEEVENTF_LEFTDOWN 这表示鼠标左键按下
        /// MOUSEEVENTF_LEFTUP 这表示鼠标左键松开
        /// MOUSEEVENTF_RIGHTDOWN 这表示鼠标右键按下
        /// MOUSEEVENTF_RIGHTUP 这表示鼠标右键松开
        /// MOUSEEVENTF_MIDDLEDOWN 这表示鼠标中键按下
        /// MOUSEEVENTF_MIDDLEUP 这表示鼠标中键松开
        /// MOUSEEVENTF_WHEEL
        /// </param>
        /// <param name="dx">指定鼠标沿x轴的绝对位置或者从上次鼠标事件产生以来移动的数量，依赖于MOUSEEVENTF_ABSOLUTE的设置。给出的绝对数据作为鼠标的实际X坐标；给出的相对数据作为移动的mickeys数。一个mickey表示鼠标移动的数量，表明鼠标已经移动。</param>
        /// <param name="dy">指定鼠标沿y轴的绝对位置或者从上次鼠标事件产生以来移动的数量，依赖于MOUSEEVENTF_ABSOLUTE的设置。给出的绝对数据作为鼠标的实际y坐标，给出的相对数据作为移动的mickeys数。</param>
        /// <param name="dwData">如果dwFlags为MOUSEEVENTF_WHEEL，则dwData指定鼠标轮移动的数量。正值表明鼠标轮向前转动，即远离用户的方向；负值表明鼠标轮向后转动，即朝向用户。一个轮击定义为WHEEL_DELTA，即120。如果dwFlagsS不是MOUSEEVENTF_WHEEL，则dWData应为零。</param>
        /// <param name="dwExtraInfo">指定与鼠标事件相关的附加32位值。应用程序调用函数GetMessageExtraInfo来获得此附加信息。</param>
        [DllImport("user32.dll")]
        public extern static void mouse_event(int dwFlag, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

        #endregion
    }
}

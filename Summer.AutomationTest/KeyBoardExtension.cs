using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace Summer.AutomationTest
{
    /// <summary>
    /// KeyBoardExtension
    /// </summary>
    public static class KeyBoardExtension
    {
        /// <summary>
        /// 输入字符串
        /// </summary>
        /// <param name="automationElement">UI自动化元素</param>
        /// <param name="str">字符串</param>
        public static void InputString(this AutomationElement automationElement, string str)
        {
            ValuePattern valuePattern = (ValuePattern)automationElement.GetCurrentPattern(ValuePattern.Pattern);
            valuePattern.SetValue(str);
        }
    }
}

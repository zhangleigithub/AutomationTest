using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace Summer.AutomationTest
{
    /// <summary>
    /// PropertyExtension
    /// </summary>
    public static class PropertyExtension
    {
        /// <summary>
        /// 是否可用
        /// </summary>
        /// <param name="automationElement">UI自动化元素</param>
        /// <returns>是否可用</returns>
        public static bool IsEnable(this AutomationElement automationElement)
        {
            return automationElement.Current.IsEnabled;
        }
    }
}

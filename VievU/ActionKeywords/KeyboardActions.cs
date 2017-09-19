using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace VievU.ActionKeywords
{
    class KeyboardActions
    {
        /// <summary>
        /// this methos take element and driver as parameter to send text into input field operation.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="keyvalues"></param>
        /// <param name="driver"></param>
        public static void SendKeys(IWebElement element,string keyvalues, IWebDriver driver)
        {
            try
            {
                element.SendKeys(keyvalues);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}

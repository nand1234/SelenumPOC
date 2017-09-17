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

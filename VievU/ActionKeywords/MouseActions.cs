using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace VievU.ActionKeywords
{
    class MouseActions
    {
        /// <summary>
        /// This methos take element and driver as parameter and performe Click operation.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="driver"></param>
        
        public static void Click(IWebElement element, IWebDriver driver)
        {
            try
            {
                element.Click();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

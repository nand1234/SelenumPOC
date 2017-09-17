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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace VievU.UIElementWait
{
    class ElementGlobalWait
    {
        /// <summary>
        /// Return Element for operation
        /// </summary>
        public static IWebElement element;
        /// <summary>
        /// this method accept below param and return element for operation.
        /// fluent wait, as this will try to find element again and again until it find it or until the final timer runs out.
        /// </summary>
        /// <param name="Locator"></param>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static IWebElement Find(By Locator, IWebDriver driver)
        {
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(60);
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            element = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(Locator);
            });
            return element;
        }
    }
        
}

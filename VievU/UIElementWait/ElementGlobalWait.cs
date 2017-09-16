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
        public static IWebElement element;
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

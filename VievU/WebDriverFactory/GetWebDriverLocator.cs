using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using VievU.UIElementWait;

namespace VievU.WebDriverFactory
{
    class GetWebDriverLocator 
    {
        /// <summary>
        /// Wrapper Class to retrun Locator detail required to search element on UI for operation
        /// </summary>
        private static By by;
        private static IWebElement Element;
        private static By GetLocator(String LocatorName, String LocatorValue)
        {
            switch (LocatorName)
            {
                case "Id":
                    by = By.Id(LocatorValue);
                    break;
                case "Name":
                    by = By.Name(LocatorValue);
                    break;
                case "CssSelector":
                    by = By.CssSelector(LocatorValue);
                    break;
                case "LinkText":
                    by = By.LinkText(LocatorValue);
                    break;
                case "PartialLinkText":
                    by = By.PartialLinkText(LocatorValue);
                    break;
                case "TagName":
                    by = By.TagName(LocatorValue);
                    break;
                case "XPath":
                    by = By.XPath(LocatorValue);
                    break;

                default:
                    by = By.Id(LocatorValue);
                    break;
            }

            return by;
        }

        /// <summary>
        /// This method take below parameter and pass it to global wait method to search element on UI
        /// </summary>
        /// <param name="LocatorType"></param>
        /// <param name="LocatorValue"></param>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static IWebElement FindElement(String LocatorType, String LocatorValue, IWebDriver driver)
        {
           By locator= GetLocator(LocatorType, LocatorValue);
            Element =ElementGlobalWait.Find(locator, driver);
            return Element;
        }

    }
}

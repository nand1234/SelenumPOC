using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using VievU.WebDriverFactory;

/// <summary>
/// Retrun Login Page Locator type and Locator value required for searching element on UI
/// </summary>
namespace VievU.UIPageRepository
{
    class LoginUI 
    {
        /// <summary>
        /// Private member to store Locatortype and Value required to search element on UI
        /// </summary>
        private String  GetUserNameLocatorType = "Id";
        private String GetPasswordLocatorType = "Id";
        private String GetUserNameLocatorvalue = "Login";
        private String GetPasswordLocatorvalue = "Password";
        private String Submitlocatortype = "CssSelector";
        private String SubmitlocatorValue = "input[type=submit]";

        /// <summary>
        /// This method first search for Username element on UI and wait unit element is displayed and retrun element for operation
        /// </summary>
        /// <param name="driver"></param>
        /// <returns> username</returns>
        public IWebElement Username(IWebDriver driver)
        {
            IWebElement username = GetWebDriverLocator.FindElement(GetUserNameLocatorType, GetUserNameLocatorvalue, driver);

            return username;
        }

        /// <summary>
        /// This method first search for Password element on UI and wait unit element is displayed and retrun element for operation
        /// </summary>
        /// <param name="driver"></param>
        /// <returns> Passowrd</returns>
        public IWebElement Password(IWebDriver driver)
        {
            IWebElement Password = GetWebDriverLocator.FindElement(GetPasswordLocatorType, GetPasswordLocatorvalue, driver);
            return Password;
        }

        /// <summary>
        /// This method first search for Submit element on UI and wait unit element is displayed and retrun element for operation
        /// </summary>
        /// <param name="driver"></param>
        /// <returns> Submit</returns>
        public IWebElement Submit(IWebDriver driver)
        {
            IWebElement Submit = GetWebDriverLocator.FindElement(Submitlocatortype, SubmitlocatorValue, driver);
            return Submit;
        }



    }

}

    

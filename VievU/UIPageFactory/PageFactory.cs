using System;
using VievU.UIPageRepository;
using OpenQA.Selenium;
using VievU.WebDriverFactory;
using VievU.ActionKeywords;

namespace VievU.UIPageFactory
{
    class PageFactory
    {
        /// <summary>
        /// This method table below parameters and perform operation required to login into website
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <param name="driver"></param>
        public void login(String Username, String Password, IWebDriver driver)
        {


            LoginUI Ui = new LoginUI();
            IWebElement GetusernameField = Ui.Username(driver);
            IWebElement GetSubmitButton = Ui.Submit(driver);
            KeyboardActions.SendKeys(GetusernameField, Username, driver);
            MouseActions.Click(GetSubmitButton, driver);
            IWebElement GetPasswordField = Ui.Password(driver);
            KeyboardActions.SendKeys(GetPasswordField, Password, driver);
            IWebElement GetLoginButton = Ui.Submit(driver);
            MouseActions.Click(GetLoginButton, driver);

        }
    }
}

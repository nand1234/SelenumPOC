using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VievU.UIPageRepository;
using OpenQA.Selenium;
using VievU.WebDriverFactory;
using VievU.ActionKeywords;

namespace VievU.UIPageFactory
{
    class PageFactory
    {
        public void login(String Username, String Password, IWebDriver driver)
        {
            LoginUI Ui = new LoginUI();
            String Usernametype = Ui.GetPasswordLocatorType();
            String Passwordtype = Ui.GetPasswordLocatorType();
            String UsernameValue = Ui.GetUserNameLocatorvalue();
            String paswordValue = Ui.GetPasswordLocatorvalue();
            String SubmitlocatorType = Ui.Submitlocatortype();
            String submitLocatorValue = Ui.SubmitlocatorValue();
            IWebElement username = GetWebDriverLocator.FindElement(Usernametype, UsernameValue, driver);
            IWebElement Submit = GetWebDriverLocator.FindElement(SubmitlocatorType, submitLocatorValue, driver);
            KeyboardActions.SendKeys(username, Username, driver);
            MouseActions.Click(Submit, driver);
            IWebElement Pass = GetWebDriverLocator.FindElement(Passwordtype, paswordValue, driver);
            KeyboardActions.SendKeys(Pass, Password, driver);
            IWebElement login = GetWebDriverLocator.FindElement(SubmitlocatorType, submitLocatorValue, driver);
            MouseActions.Click(login, driver);
        }
    }
}

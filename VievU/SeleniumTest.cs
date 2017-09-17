using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using VievU.UIPageRepository;
using VievU.WebDriverFactory;
using VievU.ActionKeywords;
using VievU.TestData;

namespace VievU
{
    [TestClass]
    public class SeleniumTest
    {
        public enum Browser
            {
            Chrome,
            IE,
            Firefox
        }

        private String URL = "https://demo.vievusolution.com/";

        [TestInitialize]
        public void importTestdata()
        {
            ImportTestData import = new ImportTestData();
            import.importTestData();
        }
        


        [TestMethod]
        public  void IETest()
        {
          IWebDriver driver=  WebDriverFactory.WebDriver.GetBrowser(Browser.IE.ToString());
          WebDriverFactory.WebDriver.launchURL(URL);

            LoginUI Ui = new LoginUI();
            String Usernametype = Ui.GetPasswordLocatorType();
            String Passwordtype = Ui.GetPasswordLocatorType();
            String UsernameValue = Ui.GetUserNameLocatorvalue();
            String paswordValue = Ui.GetPasswordLocatorvalue();
            String SubmitlocatorType = Ui.Submitlocatortype();
            String submitLocatorValue = Ui.SubmitlocatorValue();
            IWebElement username = GetWebDriverLocator.FindElement(Usernametype, UsernameValue, driver);
            IWebElement Submit = GetWebDriverLocator.FindElement(SubmitlocatorType, submitLocatorValue, driver);
            KeyboardActions.SendKeys(username, "Admin", driver);
            MouseActions.Click(Submit, driver);
            IWebElement Password = GetWebDriverLocator.FindElement(Passwordtype, paswordValue, driver);
            KeyboardActions.SendKeys(Password, "Vievu", driver);
            IWebElement login = GetWebDriverLocator.FindElement(SubmitlocatorType, submitLocatorValue, driver);
            MouseActions.Click(login, driver);




        }
        [TestMethod]
        public void FFTest()
        {
            IWebDriver driver = WebDriverFactory.WebDriver.GetBrowser(Browser.Firefox.ToString());
            WebDriverFactory.WebDriver.launchURL(URL);
            LoginUI Ui = new LoginUI();
            String Usernametype = Ui.GetPasswordLocatorType();
            String Passwordtype = Ui.GetPasswordLocatorType();
            String UsernameValue = Ui.GetUserNameLocatorvalue();
            String paswordValue = Ui.GetPasswordLocatorvalue();
            String SubmitlocatorType = Ui.Submitlocatortype();
            String submitLocatorValue = Ui.SubmitlocatorValue();
            IWebElement username = GetWebDriverLocator.FindElement(Usernametype, UsernameValue, driver);
            IWebElement Submit = GetWebDriverLocator.FindElement(SubmitlocatorType, submitLocatorValue, driver);
            KeyboardActions.SendKeys(username, "Admin", driver);
            MouseActions.Click(Submit, driver);
            IWebElement Password = GetWebDriverLocator.FindElement(Passwordtype, paswordValue, driver);
            KeyboardActions.SendKeys(Password, "Vievu", driver);
            IWebElement login = GetWebDriverLocator.FindElement(SubmitlocatorType, submitLocatorValue, driver);
            MouseActions.Click(login, driver);

        }
        [TestMethod]
        public void ChromeTest()
        {
            IWebDriver driver = WebDriverFactory.WebDriver.GetBrowser(Browser.Chrome.ToString());
            WebDriverFactory.WebDriver.launchURL(URL);

            LoginUI Ui = new LoginUI();
            String Username = Ui.GetPasswordLocatorType();
            String Password = Ui.GetPasswordLocatorType();
            IWebElement username = GetWebDriverLocator.FindElement("Id", "email", driver);
            username.SendKeys("Nandkumar.kumar@facebook.com");

        }
    }
}

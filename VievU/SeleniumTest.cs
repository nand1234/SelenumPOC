using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using VievU.UIPageRepository;
using VievU.WebDriverFactory;


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

        [TestMethod]
        public  void IETest()
        {
          IWebDriver driver=  WebDriverFactory.WebDriver.GetBrowser(Browser.IE.ToString());
          WebDriverFactory.WebDriver.launchURL("https://www.facebook.com/");

            LoginUI Ui = new LoginUI();
            String Username = Ui.GetPasswordLocatorType();
            String Password = Ui.GetPasswordLocatorType();
            IWebElement username = GetWebDriverLocator.FindElement("Id","email",driver);
            username.SendKeys("Nandkumar.kumar@facebook.com");

        }
        [TestMethod]
        public void FFTest()
        {
            IWebDriver driver = WebDriverFactory.WebDriver.GetBrowser(Browser.Firefox.ToString());
            WebDriverFactory.WebDriver.launchURL("https://www.facebook.com/");

            LoginUI Ui = new LoginUI();
            String Username = Ui.GetPasswordLocatorType();
            String Password = Ui.GetPasswordLocatorType();
            IWebElement username = GetWebDriverLocator.FindElement("Id", "email", driver);
            username.SendKeys("Nandkumar.kumar@facebook.com");

        }
        [TestMethod]
        public void ChromeTest()
        {
            IWebDriver driver = WebDriverFactory.WebDriver.GetBrowser(Browser.Chrome.ToString());
            WebDriverFactory.WebDriver.launchURL("https://www.facebook.com/");

            LoginUI Ui = new LoginUI();
            String Username = Ui.GetPasswordLocatorType();
            String Password = Ui.GetPasswordLocatorType();
            IWebElement username = GetWebDriverLocator.FindElement("Id", "email", driver);
            username.SendKeys("Nandkumar.kumar@facebook.com");

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using VievU.UIPageRepository;
using VievU.WebDriverFactory;
using VievU.ActionKeywords;
using VievU.UIPageFactory;

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
            // ImportTestData import = new ImportTestData();
            //import.importTestData();
        }

        /// <summary>
        /// Test Suite for IE Browser
        /// </summary>
        [TestMethod]
        public void IETest()
        {
            IWebDriver driver = WebDriverFactory.WebDriver.GetBrowser(Browser.IE.ToString());
            WebDriverFactory.WebDriver.launchURL(URL);
            PageFactory login = new PageFactory();
            login.login("Admin", "Vievu", driver);
        }

        /// <summary>
        /// Test Suite for FIrefox browser
        /// </summary>

        [TestMethod]
        public void FFTest()
        {
            IWebDriver driver = WebDriverFactory.WebDriver.GetBrowser(Browser.Firefox.ToString());
            WebDriverFactory.WebDriver.launchURL(URL);
            PageFactory login = new PageFactory();
            login.login("Admin","Vievu",driver);
            
        }

        /// <summary>
        /// Test Suite for Chrome Browser
        /// </summary>
        [TestMethod]
        public void ChromeTest()
        {
            IWebDriver driver = WebDriverFactory.WebDriver.GetBrowser(Browser.Chrome.ToString());
            WebDriverFactory.WebDriver.launchURL(URL);
            PageFactory login = new PageFactory();
            login.login("Admin", "Vievu", driver);

        }
    }
}

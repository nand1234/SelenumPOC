using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace VievU.WebDriverFactory
{
    class WebDriver
    {
        private static IWebDriver driver;
     
        public static IWebDriver GetBrowser(String Browser)
        {
            
                switch (Browser)
                {

                    case "Chrome":
                        driver = new ChromeDriver(@"..\..\SeleniumDriverFile");
                        break;
                    case "IE":
                        driver = new InternetExplorerDriver(@"..\..\SeleniumDriverFile");
                        break;
                    case "Firefox":
                        driver = new FirefoxDriver();
                        break;

                    default:
                        Console.WriteLine("Provided Browser is not exist");
                        break;

                }
            
          
            return driver;


        }

        public static void launchURL(String URL)
        {
            driver.Navigate().GoToUrl(URL);

        }
           
        }
    }


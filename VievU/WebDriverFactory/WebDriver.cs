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
     
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Browser"></param>
        /// <returns></returns>
        public static IWebDriver GetBrowser(String Browser)
        {
            
                switch (Browser)
                {

                    case "Chrome":
                        driver = new ChromeDriver(@"..\..\SeleniumDriverFile");
                    driver.Manage().Window.Maximize();
                        
                        break;
                    case "IE":
                        driver = new InternetExplorerDriver(@"..\..\SeleniumDriverFile");
                    driver.Manage().Window.Maximize();
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="URL"></param>
        public static void launchURL(String URL)
        {
            driver.Navigate().GoToUrl(URL);

        }
           
        }
    }


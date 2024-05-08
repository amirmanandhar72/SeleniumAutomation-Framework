using AutomationFrameworkSelenium.Resources;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkSelenium.TestCase
{
    public class BaseTestCase
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver= new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Config.URl);
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
         

        }

        [OneTimeTearDown]
        public void TearDown() { 
        driver.Quit();
        }

    }
}

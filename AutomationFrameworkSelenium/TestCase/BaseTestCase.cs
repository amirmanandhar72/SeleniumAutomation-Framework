using AutomationFrameworkSelenium.Resources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

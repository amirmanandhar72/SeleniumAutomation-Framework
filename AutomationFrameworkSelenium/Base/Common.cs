using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkSelenium.Base
{
    public class Common
    {
        public IWebDriver driver;

        public Common(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitForPageToLoad()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        public void ShouldBeEqual(string actual, string expected)
        {
            try
            {
                Assert.That(actual, Is.EqualTo(expected));
                TestContext.WriteLine(expected + " matched");
            }
            catch (Exception e)
            {
                TestContext.WriteLine(e);

            }
        }
    }
}

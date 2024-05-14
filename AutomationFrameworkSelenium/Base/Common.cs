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


        public bool IsSubmitButtonHidden()
        {
            try
            {
                var submitButton = driver.FindElement(By.XPath("//button[@type='submit']"));
                return submitButton.GetAttribute("class").Contains("ng-hide");
            }
            catch (NoSuchElementException)
            {
                // If the button is not found, it might be hidden or not present at all
                return true;
            }
        }
        public void ShouldBeTrue(bool condition, string message = "Condition should be true but was false")
        {
            // Assertion logic
            Assert.IsTrue(condition, message);
            TestContext.WriteLine("Condition should be true:"+ condition);


        }

        public void ShouldBeFalse(bool condition, string message = "Condition should be false but was true")
        {
            // Assertion logic
            Assert.IsFalse(condition, message);

            TestContext.WriteLine("Condition should be False:"+ condition);

        }
    }
}

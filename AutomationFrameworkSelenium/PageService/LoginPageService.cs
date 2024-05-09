using AutomationFrameworkSelenium.Base;
using AutomationFrameworkSelenium.PageObjects;
using OpenQA.Selenium;

namespace AutomationFrameworkSelenium.PageService
{
    public class LoginPageService: BaseService

    {
        public LoginPageService(IWebDriver driver):base(driver) { }

        public CustomerPageService ClickOnCustomerLogin()
        {
            driver.FindElement(By.XPath(LoginPageObject.CustomerLoginXpath)).Click();
            return new CustomerPageService(driver);
        }

    }

   
}

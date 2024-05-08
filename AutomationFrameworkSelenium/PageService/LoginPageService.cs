using AutomationFrameworkSelenium.Base;
using AutomationFrameworkSelenium.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

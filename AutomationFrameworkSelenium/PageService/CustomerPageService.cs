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
    public class CustomerPageService : BaseService
    {
        public CustomerPageService(IWebDriver driver) : base(driver)
        {
        }


        public string GetTitle()
        {
           return driver.FindElement(By.XPath(CustomerPageObject.selectnameXpath)).Text;
        }

        public void selectOption(string cusName)
        {
            driver.FindElement(By.XPath(String.Format(CustomerPageObject.selectNameDropDownXpath, cusName))).Click();

        }
    }


}

using AutomationFrameworkSelenium.PageService;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkSelenium.TestCase
{
    public class LoginPageTestCase:BaseTestCase
    {
        [Test]
        public void Verification_of_Customer_Login()
        {

            var login = new LoginPageService(driver);
            login.WaitForPageToLoad();
            login.ClickOnCustomerLogin();

            
         

        }

    }
}

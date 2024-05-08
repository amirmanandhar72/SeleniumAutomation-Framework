using AutomationFrameworkSelenium.PageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkSelenium.TestCase
{
    public class CustomerLoginTestCase:BaseTestCase
    {
        [Test]

       public void Test_Customer_Login()
        {
            var login = new LoginPageService(driver);
            var customerLogin= login.ClickOnCustomerLogin();
            customerLogin.WaitForPageToLoad();

            customerLogin.ShouldBeEqual("Your Name :", customerLogin.GetTitle());
            customerLogin.selectOption("Harry ");
            
        }

    }
}

using AutomationFrameworkSelenium.PageService;
using NUnit.Framework;

namespace AutomationFrameworkSelenium.TestCase
{
    public class CustomerLoginTestCase:BaseTestCase
    {
        [Test]

       public void Test_Customer_Login()
        {
            var login = new LoginPageService(driver);
            var customerLogin= login.ClickOnCustomerLogin();
            customerLogin.common.WaitForPageToLoad();

            customerLogin.common.ShouldBeEqual("Your Name :", customerLogin.GetTitle());
            customerLogin.selectOption("Harry ");
            
        }

    }
}

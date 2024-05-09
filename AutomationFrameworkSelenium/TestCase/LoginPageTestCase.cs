using AutomationFrameworkSelenium.PageService;
using NUnit.Framework;

namespace AutomationFrameworkSelenium.TestCase
{
    public class LoginPageTestCase:BaseTestCase
    {
        [Test]
        public void Verification_of_Customer_Login()
        {

            var login = new LoginPageService(driver);
            login.common.WaitForPageToLoad();
            login.ClickOnCustomerLogin();

            
         

        }

    }
}

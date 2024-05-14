using AutomationFrameworkSelenium.PageService;
using NUnit.Framework;

namespace AutomationFrameworkSelenium.TestCase
{
    public class CustomerLoginTestCase:BaseTestCase
    {

        public CustomerPageService customerLogin;
        [Test]

       public void Test_Customer_Login()
        {
            var login = new LoginPageService(driver);
            customerLogin= login.ClickOnCustomerLogin();
            customerLogin.common.WaitForPageToLoad();

            customerLogin.common.ShouldBeEqual("Your Name :", customerLogin.GetTitle());
            bool submitButton = customerLogin.common.IsSubmitButtonHidden();
            customerLogin.common.ShouldBeTrue(submitButton);
            customerLogin.selectOption("Harry ");
            
        }

        [Test]

        public void Customer_Deposit_test()
        {
          Test_Customer_Login();
           bool submitButton= customerLogin.common.IsSubmitButtonHidden();
           customerLogin.common.ShouldBeFalse(submitButton);

            
        }

    }
}

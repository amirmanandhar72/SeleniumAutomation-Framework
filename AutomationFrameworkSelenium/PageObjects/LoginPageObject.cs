using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkSelenium.PageObjects
{
    public class LoginPageObject
    {

        public static string CustomerLoginXpath = "//button[@ng-click='customer()']";

        public static string BankManagerLoginXpath = "//button[@ng-click='manager()']";
    }
}

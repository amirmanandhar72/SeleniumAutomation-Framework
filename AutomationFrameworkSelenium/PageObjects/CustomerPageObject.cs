using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkSelenium.PageObjects
{
    public class CustomerPageObject
    {
        public static string selectnameXpath = "//label";

        public static string selectNameDropDownXpath = "//option[contains(text(),'{0}')]";
    }
}

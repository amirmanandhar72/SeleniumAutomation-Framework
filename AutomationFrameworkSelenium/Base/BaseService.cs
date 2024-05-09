using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkSelenium.Base
{
    public class BaseService
    {
        public IWebDriver driver;
        public Common common;

        public BaseService(IWebDriver driver) { 
            this.driver = driver;
            this.common = new Common(driver);
        
        }

       
    }
}

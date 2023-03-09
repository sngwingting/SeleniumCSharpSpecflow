using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Pages
{
    class Homepage : DriverHelper
    {
        IWebElement clsRegister => Driver.FindElement(By.CssSelector(".ico-register"));

        public void clickRegBtn() => clsRegister.Click();
    }
}

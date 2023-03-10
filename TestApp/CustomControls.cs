using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace TestApp
{
    public class CustomControls : DriverHelper

    {
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        public void enterText(IWebElement webElement, String value) => webElement.SendKeys(value);

        public void clickElement(IWebElement webElement) => webElement.Click();

        public void dropdownSelect(IWebElement webElement, String value)
        {
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//option[. = '" + value + "']")));
            element.Click();
        }
    }
    
}

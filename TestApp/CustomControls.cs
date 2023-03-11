using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Xml.Linq;
using SeleniumExtras.WaitHelpers;

namespace TestApp
{
    public class CustomControls : DriverHelper

    {
        WaitManager waitInitialise = new WaitManager();

        public void enterText(By by, String value)
        {
            waitInitialise.waitInitialize(by, waitInitialise.genericWait); 
            Driver.FindElement(by).SendKeys(value);
        }

        public void clickElement(By by)
        {
            waitInitialise.waitInitialize(by, waitInitialise.genericWait);
            Driver.FindElement(by).Click();
        }
        public bool isDisplayed(By by)
        {
            waitInitialise.waitInitialize(by, waitInitialise.genericWait);
            return Driver.FindElement(by).Displayed;
        }

        public void dropdownSelect(By by, String value)
        {
            waitInitialise.waitInitialize(by, waitInitialise.genericWait);
            Driver.FindElement(by).Click();
        }

    }
}

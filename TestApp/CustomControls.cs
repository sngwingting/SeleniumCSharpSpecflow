/*
 * This class defines all the custom controls as well as the
 * basic actions performed such as click, assertion etc...
 * 
 * 
 */


namespace TestApp
{
    public class CustomControls

    {
        IWebDriver Driver;
        WaitManager waitInitialise;
        public CustomControls(IWebDriver webDriver)
        {
            this.Driver = webDriver;
            waitInitialise = new WaitManager(webDriver);
        }

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

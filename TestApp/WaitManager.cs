using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestApp
{
    public class WaitManager 
    {
        WebDriverWait waitDriver;
        IWebDriver Driver;
        
        public WaitManager(IWebDriver webDriver)
        {
            this.Driver = webDriver;
        }
        public int genericWait
        {
            get { return 10; }
        }

        public void waitInitialize(By by,int waitTime) 
        {
            waitDriver = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTime));
            waitDriver.Until(ExpectedConditions.ElementExists(by));
        }
        

    }
}

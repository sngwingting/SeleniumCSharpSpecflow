using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

/*
 * This class contains all the wait methods and properties
 * In addition to the elementExists wait, other wait methods such 
 * as wait for element to be clickable ect... can be added here
 * 
 * Other wait times can also be added as property: here only a generic wait time
 * of 10 seconds has been defined
 * 
 * This class is used in the customControls class so that an explicit wait is done
 * for every action performed (clicks, assertions etc)
 * 
 */

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

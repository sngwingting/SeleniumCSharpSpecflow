using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace TestApp
{
    public class WaitManager : DriverHelper
    {
        WebDriverWait waitDriver;
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

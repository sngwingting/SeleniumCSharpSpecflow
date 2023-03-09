using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class config : DriverHelper
    {
        public static void configReader()
        {
            [OneTimeSetUp]
             void globalSetup()
            {
                Driver = new ChromeDriver();
            }
            [OneTimeTearDown]
             void globalTearDown()
            {
                Driver.Quit();
            }
        }
        
    }
}

using OpenQA.Selenium;
namespace TestApp

    /*
     * This class contains all URL-related properties and methods
     * A baseurl property has been added but this can be further 
     * expanded by adding domains and urls of different pages
     * 
     */

{
    public class urlManager
    {
        IWebDriver Driver;
        public urlManager(IWebDriver webDriver)
        {
            this.Driver = webDriver;
        }

        public String baseUrl
        {
            get { return "https://demo.nopcommerce.com/";  }
        } 

        //Method to navigate to a url
        public void openUrl(IWebDriver Driver, String url) => Driver.Navigate().GoToUrl(url);
    }
}

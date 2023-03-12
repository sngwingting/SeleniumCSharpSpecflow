using OpenQA.Selenium;
namespace TestApp
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

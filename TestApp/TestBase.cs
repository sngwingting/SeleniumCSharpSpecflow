using OpenQA.Selenium.Support.Extensions;

namespace TestApp
{
    public class TestBase
    {
        protected IWebDriver Driver;
        protected string feature;

        public TestBase(IWebDriver driver, string feature) 
        {  
            this.Driver = driver;
            this.feature = feature;
        }

        public void UITest(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                var screenshot = Driver.TakeScreenshot();
                DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
                string pngName = now.ToString("yyyyMMddHHmmssfff") + ".png";
                var filePath = @"C:\\Users\\sngwingt\\source\\repos\\TestApp\\TestApp\\Screenshots\\"+ feature +"_"+ pngName;

                screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);


                throw;
            }
        }
    }
}

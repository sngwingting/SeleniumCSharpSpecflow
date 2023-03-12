using OpenQA.Selenium;

namespace TestApp.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private DriverHelper _driverHelper;
        public Hooks1(DriverHelper driverHelper) => _driverHelper = driverHelper;
        
        [BeforeScenario("@Login")]
        public void BeforeScenarioLogin()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "incognito");
            _driverHelper.Driver = new ChromeDriver(options);
        }
        [BeforeScenario("@Registration")]
        public void BeforeScenarioRegistration()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "incognito", "--headless");
            _driverHelper.Driver = new ChromeDriver(options);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
       
}
}
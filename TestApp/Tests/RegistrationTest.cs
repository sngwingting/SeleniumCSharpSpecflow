

namespace TestApp.Tests
{
    [Binding]
    public class registrationTest : DriverHelper
    {
        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
        }
        [TearDown]
        protected void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void RegistrationTest()
        {
            config configurations = new config();
            Homepage hp = new Homepage();
            RegistrationPage regPage = new RegistrationPage();
            urlManager UrlManager = new urlManager();

            //Driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");
            UrlManager.openUrl(Driver, UrlManager.baseUrl);

            Driver.Manage().Window.Maximize();

            hp.clickRegBtn();
            regPage.ChooseFemaleGender();
            regPage.EnterFirstName("Stacey");
            regPage.EnterLastName("Ng Wing Ting");
            regPage.selectDate("13");
            regPage.selectMonth("February");
            regPage.selectYear("1998");
            regPage.EnterEmail("stacey@test.com");
            regPage.enterCompany("RAPP IO");
            regPage.enterPassword("Testing123");
            regPage.enterConfirmationPassword("Testing123");
            regPage.clickRegBtn();
            regPage.clickContinueBtn();

            Thread.Sleep(2000);

        }
    }
}

using System.Security.Principal;
using TechTalk.SpecFlow.Assist;

namespace TestApp.Tests
{
    [Binding]
    public class LoginTest
    {
        private DriverHelper _driverHelper;
        private Login login;
        private Homepage hp;
        private urlManager UrlManager;
        private TestBase testBase;
        private string feature = "Login";


        public LoginTest(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            login = new Login(_driverHelper.Driver);
            hp = new Homepage(_driverHelper.Driver);
            UrlManager = new urlManager(_driverHelper.Driver);
            testBase = new TestBase(_driverHelper.Driver, feature);
        }

        [Given(@"User is on home page")]
        public void UserOnHomepage()
        {
            testBase.UITest(() =>
            {
                Console.WriteLine("Url opened: " + UrlManager.baseUrl);
                UrlManager.openUrl(_driverHelper.Driver, UrlManager.baseUrl);
            });          
        }

        [When(@"User clicks on header login button")]
        public void UserOnLoginPage()
        {
            hp.clickLoginBtn();
        }

        [When(@"User enters email and password (.*) and (.*)")]
        public void WhenUserEntersEmailAndPassword(string email, string password)
        {
            login.EnterEmail(email);
            login.EnterPsw(password);
        }


        [When(@"User clicks on Login button")]
        public void loginbtnClick()
        {
            login.submitLogin();
        }

        [Then(@"Log Off button is displayed")]
        public void AssertLogOff()
        {
            testBase.UITest(() =>
            {
                hp.isLogOffExist();
            });

            
        }
    
        }
}

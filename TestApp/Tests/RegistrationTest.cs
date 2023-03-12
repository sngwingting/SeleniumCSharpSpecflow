
namespace TestApp.Tests
{
    [Binding]
    public class registrationTest

    {
        private DriverHelper _driverHelper;
        private RegistrationPage regPage;
        private Homepage hp;
        private urlManager UrlManager;
        private TestBase testBase;
        private string feature = "Registration";

        public registrationTest(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            regPage = new RegistrationPage(_driverHelper.Driver);
            hp = new Homepage(_driverHelper.Driver);
            UrlManager = new urlManager(_driverHelper.Driver);
            testBase = new TestBase(_driverHelper.Driver, feature);
        }


        [When(@"User clicks on header Registration button")]
        public void btnRegistrationClick()
        {
            testBase.UITest(() =>
            {
                hp.clickRegBtn();
            });
        }

        [When(@"User fills in form details (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) and (.*)")]
        public void fillRegFormDetails (String gender, string fname, string lname, string date, string month, string year, string email, string company, string psw, string confPsw)
        {
            testBase.UITest(() =>
            {
                regPage.ChooseGender(gender);
                regPage.EnterFirstName(fname);
                regPage.EnterLastName(lname);
                regPage.selectDate(date);
                regPage.selectMonth(month);
                regPage.selectYear(year);
                regPage.EnterEmail(email);
                regPage.enterCompany(company);
                regPage.enterPassword(psw);
                regPage.enterConfirmationPassword(confPsw);
            });        
        }

        [When(@"User clicks on Register button")]
        public void WhenUserClicksOnRegisterButton()
        {
            testBase.UITest(() =>
            {
                regPage.clickRegBtn();
            });
        }

        [Then(@"We can click the Continue button")]
        public void ThenTheContinueButtonIsDisplayed()
        {
            testBase.UITest(() =>
            {
                regPage.clickContinueBtn();
            });
            
        }

    }
    
}

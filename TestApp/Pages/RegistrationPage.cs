
/*
 * Class containing all IWebelements for the page and their specific methods
 * 
 */

namespace TestApp.Pages
{
    class RegistrationPage
    {
        CustomControls controls;
        private IWebDriver Driver;
        public RegistrationPage(IWebDriver driver)
        {
            this.Driver = driver;
            controls = new CustomControls(driver);
        }

        //IWebElements defined here
        #region
        By genderFemale => By.Id("gender-female");
        By genderMale => By.Id("gender-male");
        By enterFirstName => By.Id("FirstName");
        By enterLastName => By.Id("LastName");

        By dropdownDate => By.Name("DateOfBirthDay");
        By emailElement => By.Id("Email");
        By companyElement => By.Id("Company");
        By passwordElement => By.Id("Password");
        By confirmPasswordElement => By.Id("ConfirmPassword");

        By btnregister => By.Id("register-button");
        By btnContinue => By.CssSelector(".register-continue-button");

        #endregion


        //All methods related to registration page here
        #region
        public void ChooseGender(string gender)
        {
            if(gender.Equals("female"))
            {
                controls.clickElement(genderFemale);
            }else
            {
                controls.clickElement(genderMale);
            }
        }
        public void EnterFirstName(String firstname) => controls.enterText(enterFirstName, firstname);
        public void EnterLastName(String lastname) => controls.enterText(enterLastName, lastname);

        //Dropdowns
        public void selectDate(String date) => controls.dropdownSelect(dropdownDate, date);
        public void selectMonth(String month) => controls.dropdownSelect(dropdownDate, month);
        public void selectYear(String year) => controls.dropdownSelect(dropdownDate, year);

        public void EnterEmail(String email) => controls.enterText(emailElement,email);
        public void enterCompany(String company) => controls.enterText(companyElement, company);
        public void enterPassword(String psw) => controls.enterText(passwordElement, psw);

        public void enterConfirmationPassword(String psw) => controls.enterText(confirmPasswordElement, psw);
        public void clickRegBtn() => controls.clickElement(btnregister);
        public void clickContinueBtn() => controls.clickElement(btnContinue);

        #endregion
    }
}

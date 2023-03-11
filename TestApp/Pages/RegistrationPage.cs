using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp;

namespace TestApp.Pages
{
    class RegistrationPage : DriverHelper
    {
        CustomControls controls = new CustomControls();

        //IWebElements defined here
        #region
        By chooseGenderFemale => By.Id("gender-female");
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
        public void ChooseFemaleGender() => controls.clickElement(chooseGenderFemale);
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

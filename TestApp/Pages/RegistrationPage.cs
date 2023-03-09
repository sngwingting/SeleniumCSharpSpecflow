using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Pages
{
    class RegistrationPage : DriverHelper
    {

        //IWebElements defined here
        #region
        IWebElement chooseGenderFemale => Driver.FindElement(By.Id("gender-female"));
        IWebElement enterFirstName => Driver.FindElement(By.Id("FirstName"));
        IWebElement enterLastName => Driver.FindElement(By.Id("LastName"));

        IWebElement dropdownDate => Driver.FindElement(By.Name("DateOfBirthDay"));
        IWebElement emailElement => Driver.FindElement(By.Id("Email"));
        IWebElement companyElement => Driver.FindElement(By.Id("Company"));
        IWebElement passwordElement => Driver.FindElement(By.Id("Password"));
        IWebElement confirmPasswordElement => Driver.FindElement(By.Id("ConfirmPassword"));

        IWebElement btnregister => Driver.FindElement(By.Id("register-button"));
        IWebElement btnContinue => Driver.FindElement(By.CssSelector(".register-continue-button"));

        #endregion


        //All methods related to registration page here
        #region
        public void ChooseFemaleGender() => chooseGenderFemale.Click();
        public void EnterFirstName(String firstname) => enterFirstName.SendKeys(firstname);
        public void EnterLastName(String lastname) => enterLastName.SendKeys(lastname);

        //Dropdowns
        public void selectDate(String date) => dropdownDate.FindElement(By.XPath("//option[. = '"+date+"']")).Click();
        public void selectMonth(String month) => dropdownDate.FindElement(By.XPath("//option[. = '"+month+"']")).Click();
        public void selectYear(String year) => dropdownDate.FindElement(By.XPath("//option[. = '"+year+"']")).Click();

        public void EnterEmail(String email) => emailElement.SendKeys(email);
        public void enterCompany(String company) => companyElement.SendKeys(company);
        public void enterPassword(String psw) => passwordElement.SendKeys(psw);

        public void enterConfirmationPassword(String psw) => confirmPasswordElement.SendKeys(psw);
        public void clickRegBtn() => btnregister.Click();
        public void clickContinueBtn() => btnContinue.Click();

        #endregion
    }
}

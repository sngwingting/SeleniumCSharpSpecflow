﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Pages
{

    class Login : DriverHelper
    {
        CustomControls controls = new CustomControls();

        //IWebElements defined here
        #region
        By fldEmail => By.Id("Email");
        By fldPassword => By.Id("Password");
        By loginSubmit => By.CssSelector(".login-button");
        #endregion

        //All methods related to registration page here
        #region
        public void EnterEmail(String email) => controls.enterText(fldEmail, email);
        public void EnterPsw(String psw) => controls.enterText(fldPassword, psw);
        public void submitLogin() => controls.clickElement(loginSubmit);


        #endregion
    }
}
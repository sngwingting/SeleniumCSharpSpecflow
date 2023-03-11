using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Pages
{
    class Homepage : DriverHelper
    {
        CustomControls controls = new CustomControls();
        By btnRegister =>By.CssSelector(".ico-register");
        By btnLogin => By.LinkText("Log in"); 
        By btnLogOut => By.LinkText("Log out");

        public void clickRegBtn() => controls.clickElement(btnRegister);
        public void clickLoginBtn() => controls.clickElement(btnLogin);
        public bool isLogOffExist() => controls.isDisplayed(btnLogOut);

    }
}

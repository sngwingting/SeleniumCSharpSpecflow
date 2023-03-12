/*
 * Class containing all IWebelements for the page and their specific methods
 * 
 */

namespace TestApp.Pages
{
    class Homepage 
    {
        CustomControls controls;
        //private IWebDriver Driver;
        IWebDriver _driverHelper;

        public Homepage(IWebDriver driverHelper)
        {
            _driverHelper = driverHelper;
            controls = new CustomControls(driverHelper);
        }

        By btnRegister =>By.CssSelector(".ico-register");
        By btnLogin => By.LinkText("Log in"); 
        By btnLogOut => By.LinkText("Log out");

        public void clickRegBtn() => controls.clickElement(btnRegister);
        public void clickLoginBtn() => controls.clickElement(btnLogin);
        public bool isLogOffExist() => controls.isDisplayed(btnLogOut);

    }
}

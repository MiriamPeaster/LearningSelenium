using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCoreDemo.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }


        //Long way to write property:
        /*public IWebElement lnkLogin
        {
            get
            {
                return Driver.FindElement(By.LinkText("Login"));
            }
        }*/
        //Short way to write the same property:
        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        IWebElement lnkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));

        //Method to click the login button
        //Long version:
        /*public void ClickLogin()
        {
            lnkLogin.Click();
        }*/
        //Short version:
        public void ClickLogin() => lnkLogin.Click();

        public bool IsEmployeeDetailsExist() => lnkEmployeeDetails.Displayed;
    }
}

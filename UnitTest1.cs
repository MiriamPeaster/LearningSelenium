/*using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCoreDemo
{
    public class Tests1
    {
        //Hooks in NUnit
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            //Open broswer
            //Browser Driver
            IWebDriver webDriver = new ChromeDriver();

            //Navigate to site
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");


            //Login
            //Identify login button
            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Login"));

            //operation to click login link
            lnkLogin.Click();

            //Find username field on page
            var txtUserName = webDriver.FindElement(By.Name("UserName"));

            //assertion operation, verify click
            Assert.That(txtUserName.Displayed, Is.True);

            //Enter text in username textbox
            txtUserName.SendKeys("admin");

            //Enter text in password textbox
            webDriver.FindElement(By.Name("Password")).SendKeys("password");

            //Finds login input element and submits it (clicks login)
            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();

            //Checks for "Employee Details" to see if the correct page opens
            var lnkEmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));

            Assert.That(lnkEmployeeDetails.Displayed, Is.True);
        }
    }
}*/
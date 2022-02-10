using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace Exersices
{
    [TestFixture]
    public class AddToCart
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void LoadDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test]
        public void LoginProblemUser()
        {
            IWebElement Username = driver.FindElement(By.Id("user-name"));
            IWebElement Password = driver.FindElement(By.Id("password"));
            IWebElement LoginButton = driver.FindElement(By.Id("login-button"));

            Username.SendKeys("problem_user");
            Password.SendKeys("secret_sauce");
            LoginButton.Click();
        }

        [OneTimeTearDown]
        public void UnloadDriver()
        {
            driver.Quit();
        }
    }
}

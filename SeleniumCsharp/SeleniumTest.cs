using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using System;

using System.Collections.ObjectModel;

using System.IO;


namespace SeleniumCsharp
{
    public class Tests
    {
        IWebDriver driver;

        [OneTimeSetUp]

        public void Setup()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path + @"\drivers\");
        }

        //[Test]

        
        //Comment
        //public void Swag()
        //{
        //    driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        //    IWebElement Username = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div[1]/div/form/div[1]/input"));
        //    IWebElement Password = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div[1]/div/form/div[2]/input"));
        //    Username.SendKeys("standard_user");
        //    Password.SendKeys("secret_sauce");

        //    IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div[1]/div/form/input")); 
        //    LoginButton.Click();

        //    System.Threading.Thread.Sleep(2000);

        //    IWebElement Backpack = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div[1]/div[2]/div[1]/a/div"));
        //    Backpack.Click();

        //    System.Threading.Thread.Sleep(2000);

        //    IWebElement AddToCart = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div[2]/button"));
        //    AddToCart.Click();

        //    IWebElement Cart = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[3]/a"));
        //    Cart.Click();

        //    System.Threading.Thread.Sleep(2000);
        //}

        [Test]

        public void PerfTipPublish()
        {
            driver.Navigate().GoToUrl("https://sharon.centrical.me/v3/");

            System.Threading.Thread.Sleep(1000);

            IWebElement Username = driver.FindElement(By.XPath("/html/body/application-root/div[2]/div/application-desktop/div/div/div/login-page/div/div[2]/form/div/div[3]/textbox/div/input"));
            IWebElement Password = driver.FindElement(By.XPath("/html/body/application-root/div[2]/div/application-desktop/div/div/div/login-page/div/div[2]/form/div/div[4]/textbox/div/input"));
            Username.SendKeys("test152");
            Password.SendKeys("Aa123456");

            System.Threading.Thread.Sleep(1000);

            IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/application-root/div[2]/div/application-desktop/div/div/div/login-page/div/div[2]/form/div/div[6]/gm-button[1]/div/div/button"));
            LoginButton.Click();

            System.Threading.Thread.Sleep(1000);

            driver.Navigate().GoToUrl("https://sharon.centrical.me/v3/w/game/tips");

            System.Threading.Thread.Sleep(1000);

            IWebElement TipsButton = driver.FindElement(By.XPath("/html/body/application-root/div[2]/div/application-desktop/div/div/div/tips-view/div/div[2]/div/div/div[2]/div/div[1]/group-layout/div/div/div[1]/div[2]/div[1]/tip-item/div/div[2]/div/gm-button/div"));
            TipsButton.Click();

            System.Threading.Thread.Sleep(1000);

            IWebElement TempButton = driver.FindElement(By.XPath("/html/body/application-root/div[1]/popup-container/div[1]/centri-popup/div/div/tip-create/div/div/div/div[2]/div/div[1]"));
            TempButton.Click();

            System.Threading.Thread.Sleep(1000);

            IWebElement Body = driver.FindElement(By.XPath("/html/body/application-root/div[1]/popup-container/div[1]/centri-popup/div/div/tip-create/div/div/div/form/div[2]/div[1]/textbox/div[1]/textarea"));
            Body.SendKeys("text");

            System.Threading.Thread.Sleep(1000);

            IWebElement PrevButton = driver.FindElement(By.XPath("/html/body/application-root/div[1]/popup-container/div[1]/centri-popup/div/div/tip-create/div/wizard-navigation/div/div[2]/gm-button[2]/div/div"));
            PrevButton.Click();

            System.Threading.Thread.Sleep(1000);

            IWebElement SubmitButton = driver.FindElement(By.XPath("/html/body/application-root/div[1]/popup-container/div[1]/centri-popup/div/div/tip-create/div/wizard-navigation/div/div[2]/gm-button[2]/div"));
            SubmitButton.Click();

            System.Threading.Thread.Sleep(1000);

            driver.Quit();

            //    IWebElement Backpack = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div/div[1]/div[2]/div[1]/a/div"));
            //    Backpack.Click();

            //    System.Threading.Thread.Sleep(2000);

            //    IWebElement AddToCart = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/div[2]/button"));
            //    AddToCart.Click();

            //    IWebElement Cart = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[3]/a"));
            //    Cart.Click();

            //    System.Threading.Thread.Sleep(2000);
            //}

            //[Test]

            //public void verifyLogo()

            //{

            //    driver.Navigate().GoToUrl("https://www.browserstack.com/");

            //    Assert.IsTrue(driver.FindElement(By.Id("logo")).Displayed);

            //}

            //[Test]

            //public void verifyMenuItemcount()

            //{

            //    ReadOnlyCollection<IWebElement> menuItem = driver.FindElements(By.XPath("//ul[contains(@class,'horizontal-list product-menu')]/li"));

            //    Assert.AreEqual(menuItem.Count, 4);

            //}

            //[Test]

            //public void verifyPricingPage()

            //{

            //    driver.Navigate().GoToUrl("https://browserstack.com/pricing");

            //    IWebElement contactUsPageHeader = driver.FindElement(By.TagName("h1"));

            //    Assert.IsTrue(contactUsPageHeader.Text.Contains("Replace your device lab and VMs with any of these plans"));

            //}

            // [OneTimeTearDown]

            //private void TearDown() => driver.Quit();
        }
    } }
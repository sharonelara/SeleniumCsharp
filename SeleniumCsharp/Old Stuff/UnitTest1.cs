using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharp
{
    [TestFixture]
    class UnitTest1
    {
        [Test]
        public void TestOpenBrowser()
        {
            IWebDriver driver = new ChromeDriver();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutoTest
{
    
    class TestFrame <TWebDriver> where TWebDriver : IWebDriver, new()
    {
        protected IWebDriver driver;
        private static readonly string url = "https://www.linkedin.com";

        [SetUp]
        public void runDriver()
        {
            this.driver = new TWebDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);       
        }

        [TearDown]
        public void quitDriver()
        {
            driver.Close();
            //driver.Quit();
        }
    }
}

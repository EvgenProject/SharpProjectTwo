using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using AutoTest.basic;


namespace AutoTest.tests
{
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    class Case1<TWebDriver> : TestFrame<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        WelcomePage welcomePage = null;
        MainPage mainPage = null;

        [Test]
        public void test()
        {
            welcomePage = new WelcomePage(driver);
            if (welcomePage.IsLogo()) {
                mainPage = welcomePage.signIn(driver); }
            else
            {
                System.Diagnostics.Debug.WriteLine("Here");
            }
            
        }
    }
}

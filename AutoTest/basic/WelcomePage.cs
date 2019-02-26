using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace AutoTest.basic
{
    public class WelcomePage : BasePage
    {
        public WelcomePage(IWebDriver driver) : base(driver) => PageFactory.InitElements(driver, this);

        [FindsBy(How = How.XPath, Using = "//h1/img[@alt='LinkedIn']")]
        private IWebElement logo { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='login-submit']")]
        private IWebElement signInBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='login-email']")]
        private IWebElement loginField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='login-password']")]
        private IWebElement passwordField { get; set; }

        public MainPage signIn(IWebDriver driver)
        {
            inputData(loginField, "");
            inputData(passwordField, "");
            signInBtn.Click();
            return new MainPage(driver);
        }

        public bool IsLogo()
        {
            return summaryDisplayed("//h1/img[@alt='LinkedIn']");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace AutoTest
{

    public abstract class BasePage
    {
        protected IWebDriver _driver = null;
        private WebDriverWait _wait;
        private IWebElement _element;

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public bool summaryDisplayed(string by)
        {
            try
            {
                _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                //_element = _wait.Until(x => element);
                _element = _wait.Until(ExpectedConditions.ElementIsVisible((By.XPath(by))));
                return _element.Displayed;
            }
            catch
            {
                return false;
            }
        }

        public void inputData(IWebElement element, string data)
        {
            element.Clear();
            element.SendKeys(data);
        }
    }
}

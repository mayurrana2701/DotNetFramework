using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using MayurApr2020.Framework.Hooks;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    public abstract class BasePage
    {
        protected IWebDriver webDriver;
        private By PageHeading = By.CssSelector("h1");

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        protected abstract Boolean SelfVerify();

        protected string GetPageHeading()
        {
            return Hooks.WebDriver.FindElement(PageHeading).Text;
        }
    }
}

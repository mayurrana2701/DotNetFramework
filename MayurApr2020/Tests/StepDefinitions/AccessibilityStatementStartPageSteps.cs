using NUnit.Framework;
using MayurApr2020.Framework.Helpers;
using MayurApr2020.Tests.Pages;
using System.Linq;
using TechTalk.SpecFlow;
using MayurApr2020.Tests.TestSupport;

namespace MayurApr2020.Tests.StepDefinitions
{
    [Binding]
    public class AccessibilityStatementStartPageSteps : TlevelDashboardPage
    {
        [Given(@"Tlevel start page")]
        public void GivenTlevelStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
        }

        [When(@"I click on Accessibility statement link")]
        public void WhenIClickOnAccessibilityStatementLink()
        {
            PageHelper.ClickElement(AccesslibilityLink);
        }

        [Then(@"I should see Accessibility stement details in new tab in the browser")]
        public void ThenIShouldSeeAccessibilityStementDetailsInNewTabInTheBrowser()
        {
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles.Last());
            Assert.AreEqual(Constants.AccessibilityUrl, WebDriver.Url);
        }
    }
}

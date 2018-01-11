using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ValtechTest.Pages;

namespace ValtechTest.Step_Definitions
{
    [Binding]
    public sealed class HomePageStepDefs
    {
        private HomePage homePage = new HomePage();

        [When(@"I navigate to the valtech homepage")]
        [Given(@"I am on the valtech homepage")]
        public void WhenINavigateToTheValtechHomepage()
        {
            homePage.Visit();
        }

        [Then(@"I should see the Latest News section")]
        public void ThenIShouldSeeTheLatestNewsSection()
        {
            Assert.IsTrue(Browser.Driver.FindElement(homePage.LatestNewsSection).Displayed, $"Latest News section not displayed");
        }

        [When(@"I navigate to the (.+) page")]
        public void WhenINavigateToThePage(string page)
        {
            homePage.ClickOnToolbar(page);
        }

        [Then(@"I should see the (.+) header")]
        public void ThenIShouldSeeTheHeader(string page)
        {
            Assert.IsTrue(Browser.Driver.FindElement(By.XPath($".//h1[.='{page}']")).Displayed, $"H1 element with text {page} not found");
        }

        [When(@"I open the contact section")]
        public void WhenIOpenTheContactSection()
        {
            homePage.OpenContactSection();
        }

        [Then(@"I want to know the amount of offices")]
        public void ThenIWantToKnowTheAmountOfOffices()
        {
            Console.WriteLine(homePage.NumberOfOffices());
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtechTest.Pages
{
    public class HomePage
    {
        public string Url = "https://www.valtech.com";

        public By LatestNewsSection = By.XPath(".//h2[.='Latest news']");

        public By ToolbarLink = By.XPath(".//div[@id='navigationMenuWrapper']//a");

        public By ContactIcon = By.Id("contacticon");

        public By ContactSection = By.Id("contactbox");

        public void Visit()
        {
            Browser.Driver.Url = Url;
        }

        public void ClickOnToolbar(string toolbarLink)
        {
            var toolbarLinks = Browser.Driver.FindElements(ToolbarLink);
            toolbarLinks.First(link => link.GetAttribute("textContent") == toolbarLink).Click();
        }

        public void OpenContactSection()
        {
            Browser.Driver.FindElement(ContactIcon).Click();
        }

        public int NumberOfOffices()
        {
            var contact = Browser.Driver.FindElement(ContactSection);

            var offices = contact.FindElements(By.XPath(".//ul[@class='contactcities']/li"));

            return offices.Count;
        }
    }
}

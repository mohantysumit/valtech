using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace ValtechTest
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Browser.Driver = new ChromeDriver();
            Browser.Driver.Manage().Window.Maximize();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Browser.Driver.Close();
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace MyApplication
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("download.default_directory",@"D:\");
            chromeOptions.AddUserProfilePreference("intl.accept_languages", "nl");
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            var driver = new ChromeDriver(@"D:\", chromeOptions);
            driver.Navigate().GoToUrl("https://www.nseindia.com/");
            driver.Manage().Window.Maximize();
            IWebElement we = driver.FindElement(By.XPath("//div[@class='market-expert']/a[3]"));
            Actions action = new Actions(driver);
            action.MoveToElement(we);
            action.SendKeys(Keys.End);
            we.Click();
            //console.writeline("Commitcheck")
            

        }
    }
}

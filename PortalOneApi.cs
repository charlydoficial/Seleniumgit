using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace Selenium
{
    public class PortalOneAPI
    {
        [TestCase]
        public void CreateSessionAPI()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate()
                .GoToUrl(
                    "https://dp-qa-portalone.processonepayments.com/crojas_3/PaymentPortals/API/API/Session/Create?PortalOneAuthenticationKey=099AAE72-C70A-4870-8222-C7B166A37D85");

            var wait = new WebDriverWait(driver, new TimeSpan(5));
            wait.Until(d => d.FindElement(By.Id("webkit-xml-viewer-source-xml")));

            Assert.That(
                driver.FindElement(By.TagName("ResponseCode"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Success"));
            Assert.That(
                driver.FindElement(By.TagName("PortalOneSessionKey"))
                    .GetAttribute("innerHTML"), Is.Not.Null);
            driver.Close();
            driver.Quit();
        }
    }
}
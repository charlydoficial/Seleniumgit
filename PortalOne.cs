using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    public class PortalOne
    {
        [TestCase]
        public void Check_PortalOne_Dashboard_Navigation_bar_UI()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate()
                .GoToUrl("https://dp-qa-portalone.processonepayments.com/crojas_3/PaymentPortals/Dashboard/Home");
            driver.FindElement(By.Id("Username")).SendKeys("x");
            driver.FindElement(By.Id("Password")).SendKeys("123");
            driver.FindElement(By.Name("button")).Click();

            driver.FindElement(By.LinkText("General Configuration")).Click();
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[1]/div[2]/ul/li[1]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Clients"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[1]/div[2]/ul/li[2]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Manage Settings"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[1]/div[2]/ul/li[3]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Settings Validation Sets"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[1]/div[2]/ul/li[4]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Test Engine"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[1]/div[2]/ul/li[5]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Test Engine Mock"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[1]/div[2]/ul/li[6]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Test Engine New"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[1]/div[2]/ul/li[7]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Test Sequence"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[1]/div[2]/ul/li[8]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Test Sequence Chat"));

            driver.FindElement(By.LinkText("ContactOne")).Click();
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/div[2]/ul/li[1]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Calls"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/div[2]/ul/li[2]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Calls In Progress"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/div[2]/ul/li[3]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Outgoing Action Batches"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/div[2]/ul/li[4]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Outgoing Actions"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/div[2]/ul/li[5]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Outgoing Opt Out"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/div[2]/ul/li[6]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Settings"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/div[2]/ul/li[7]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Text Messages"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[2]/div[2]/ul/li[8]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Workflows"));
            
            driver.FindElement(By.LinkText("PortalOne")).Click();
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[3]/div[2]/ul/li[1]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Certificates"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[3]/div[2]/ul/li[2]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("One Inc Clients"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[3]/div[2]/ul/li[3]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Portals"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[3]/div[2]/ul/li[4]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Sentiment questions"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[3]/div[2]/ul/li[5]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Settings"));
            
            driver.FindElement(By.LinkText("PortalOne Service")).Click();
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[4]/div[2]/ul/li[1]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Agent Task Hosts"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[4]/div[2]/ul/li[2]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Service Schedule"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[4]/div[2]/ul/li[3]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Task Types"));
            
            driver.FindElement(By.LinkText("Vendor Network")).Click();
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[5]/div[2]/ul/li[1]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("Vendor Preferences Report"));
            
            driver.FindElement(By.LinkText("History - Change Logs")).Click();
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[6]/div[2]/ul/li[1]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("PortalOne Agent Task"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[6]/div[2]/ul/li[2]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("PortalOne Agent Task Host"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[6]/div[2]/ul/li[3]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("PortalOne Agent Task Type"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[6]/div[2]/ul/li[4]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("PortalOne Settings Definition"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[6]/div[2]/ul/li[5]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("PortalOne Settings Values"));
            Assert.That(
                driver.FindElement(By.XPath("/html/body/nav/div[1]/div[6]/div[2]/ul/li[6]/a"))
                    .GetAttribute("innerHTML"), Is.Not.Null.And.EqualTo("PortalOne Modal Portal"));
            driver.Close();
            driver.Quit();
        }
    }

    public static class Helper
    {
        public static void Pause(int secondsToPause)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}
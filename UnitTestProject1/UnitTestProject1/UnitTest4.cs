using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase4
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/ul")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("input-firstname")).Click();
            driver.FindElement(By.Id("input-firstname")).Clear();
            driver.FindElement(By.Id("input-firstname")).SendKeys("Pero");
            driver.FindElement(By.Id("input-lastname")).Click();
            driver.FindElement(By.Id("input-lastname")).Clear();
            driver.FindElement(By.Id("input-lastname")).SendKeys("Peric");
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("peroperic@gmail.com");
            driver.FindElement(By.Id("input-telephone")).Click();
            driver.FindElement(By.Id("input-telephone")).Clear();
            driver.FindElement(By.Id("input-telephone")).SendKeys("123456789");
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("pero123");
            driver.FindElement(By.Id("input-confirm")).Click();
            driver.FindElement(By.Id("input-confirm")).Clear();
            driver.FindElement(By.Id("input-confirm")).SendKeys("pero123");
            driver.FindElement(By.XPath("//div[@id='content']/form/div/div/a/b")).Click();
            driver.FindElement(By.Id("modal-agree")).Click();
            driver.FindElement(By.Name("agree")).Click();
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("peroperic000@gmail.com");
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
            driver.FindElement(By.LinkText("Windows (0)")).Click();
            driver.FindElement(By.LinkText("Mac (1)")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[9]")).Click();
            driver.FindElement(By.Id("cart-total")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/i")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("peroperic000@gmail.com");
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("pero123");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.LinkText("Mac (1)")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div[2]/div/div/div[2]/div[2]/button[2]/i")).Click();
            driver.FindElement(By.XPath("//a[@id='wishlist-total']/i")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys("peroperic000@gmail.com");
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/div/div[2]")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys("pero123");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.LinkText("Cameras")).Click();
            driver.FindElement(By.Id("input-sort")).Click();
            new SelectElement(driver.FindElement(By.Id("input-sort"))).SelectByText("Name (Z - A)");
            driver.FindElement(By.Id("input-sort")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[15]")).Click();
            driver.FindElement(By.LinkText("product comparison")).Click();
            driver.FindElement(By.XPath("(//input[@value='Add to Cart'])[2]")).Click();
            driver.FindElement(By.Id("input-option226")).Click();
            driver.FindElement(By.Id("input-option226")).Click();
            driver.FindElement(By.Id("button-cart")).Click();
            driver.FindElement(By.Id("input-option226")).Click();
            driver.FindElement(By.Id("input-option226")).Click();
            driver.FindElement(By.Id("input-option226")).Click();
            driver.FindElement(By.Id("input-option226")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=input-option226 | ]]
            driver.FindElement(By.Id("product")).Click();
            driver.FindElement(By.Id("button-cart")).Click();
            driver.FindElement(By.Id("input-option226")).Click();
            driver.FindElement(By.Id("input-option226")).Click();
            driver.FindElement(By.Id("input-quantity")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}

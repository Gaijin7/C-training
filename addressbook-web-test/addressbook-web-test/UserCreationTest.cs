using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AddressbookTests
{
    [TestFixture]
    public class UserCreationTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"c:\Program Files\Mozilla Firefox\firefox.exe";
            options.UseLegacyImplementation = true;
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost:8080/";
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
        public void TheUntitled2Test()
        {
            OpenHomePage();
            Login(new UserLogin("admin", "secret"));
            UserPage();
            UserData user = new UserData("sfghshg");
            user.Lastname = "Mur";
            user.Nickname = "Kol";
            user.Address = "Penza";
            user.Address2 = "fthrth";
            user.Home = "Ternovka";
            CreationNewUser(user);
            SubmitUserCreation();
            ReturnUserPage();
            Logaut();
        }

        private void Logaut()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        private void ReturnUserPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }

        private void SubmitUserCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        private void CreationNewUser(UserData user)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(user.Firstname);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(user.Lastname);
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys(user.Nickname);
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(user.Address);
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(user.Home);
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(user.Address2);
        }

        private void UserPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void Login(UserLogin user)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(user.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(user.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        private void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/index.php");
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

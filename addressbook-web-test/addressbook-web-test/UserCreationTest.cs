using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class UserCreationTests : TestBase
    {
       
        [Test]
        public void UserCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            UserPage();
            UserData user = new UserData("sfghshg");
            user.Lastname = "Mur";
            user.Nickname = "Kol";
            user.Address = "Penza";
            user.Address2 = "fthrth";
            user.Home = "Ternovka";
            CreationNewUser(user);
            SubmitCreation();
            ReturnUserPage();
            Logaut();
        }

    }
}

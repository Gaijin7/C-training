using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin","secret"));
            navigator.GoToGroupPage();
            NewGroupCreation();
            FillGroupForm(new GroupData("Gai","Mur","Kol"));
            SubmitCreation();
            ReturnToGroupsPage();
            loginHelper.Logaut();
        }
        
    }
}

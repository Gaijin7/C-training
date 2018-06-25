﻿using System;
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
            GoToHomePage();
            Login(new AccountData("admin","secret"));
            GoToGroupPage();
            NewGroupCreation();
            FillGroupForm(new GroupData("Gai","Mur","Kol"));
            SubmitCreation();
            ReturnToGroupsPage();
            Logaut();
        }
        
    }
}

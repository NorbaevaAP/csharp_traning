using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContaktCreationTests : TestBase
    {
        [Test]
        public void ContaktCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            InitnewContaktCreation();
            ContaktData group = new ContaktData("a", "a");
            FillContaktForm(group);
            SubmitContaktCreation();
            GoToMainPage();
            GoExit();
        }
    }
}

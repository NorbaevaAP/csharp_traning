using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContaktCreationTests : AuthTestBase
    {
        [Test]
        public void ContaktCreationTest()
        {
            ContaktData group = new ContaktData("a", "a");
            app.Contakts
                .InitnewContaktCreation()
                .FillContaktForm(group)
                .SubmitContaktCreation()
                .GoExit();
        }
    }
}

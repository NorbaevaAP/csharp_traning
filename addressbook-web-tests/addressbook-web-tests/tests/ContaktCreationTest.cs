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
            CreateContact(app);
            app.Contakts.GoExit();
        }

        public static void CreateContact(ApplicationManager app)
        {
            ContaktData group = new ContaktData("a1", "a1");
            app.Contakts
                .InitNewContaktCreation()
                .FillContaktForm(group)
                .SubmitContaktCreation();
        }
    }
}

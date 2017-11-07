using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContaktCreationTests : AuthTestBase
    {
        [Test]
        public void ContaktCreationTest()
        {
            List<ContaktData> oldContakts = app.Contakts.GetContaktList();

            CreateContact(app);

            List<ContaktData> newContakts = app.Contakts.GetContaktList();
            Assert.AreEqual(oldContakts.Count + 1, newContakts.Count);

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

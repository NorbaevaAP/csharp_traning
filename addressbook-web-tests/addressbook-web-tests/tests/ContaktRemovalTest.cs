using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContaktRemovalTests : AuthTestBase
    {

        [Test]
        public void ContaktRemovalTest()
        {
            if (!app.Contakts.CheckAnyExsists())
            {
                ContaktCreationTests.CreateContact(app);
                app.Navigator.GoToHomePage();
            }

            app.Contakts.Remove(1);
        }

    }
}

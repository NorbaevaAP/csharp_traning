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
            app.Contakts.Remove(1);
        }

    }
}

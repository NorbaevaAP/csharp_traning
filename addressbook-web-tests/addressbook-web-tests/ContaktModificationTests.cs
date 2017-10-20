using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContaktModificationTests : AuthTestBase
    {
        [Test]
        public void ContaktModificationTest()
        {
            ContaktData newData = new ContaktData("pp", "ss");

            app.Contakts.Modify(1, newData);
        }
    }
}

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests//уникальное пространство имен для всех тестов
{
    [TestFixture] //атрибуты 
    public class GroupCreationTests : TestBase // класс должен быть уникальным
    { 
        [Test]  //тестовый метод
        public void GroupCreationTest() // тестовый метод дб уникальным
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            Initnewgroupcreation();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            Fillgroupform(group);
            Submitgroupcreation();
            Returntogrouppage();
        }
    }
}

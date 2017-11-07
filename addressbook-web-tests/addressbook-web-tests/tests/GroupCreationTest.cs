using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;


namespace WebAddressbookTests//уникальное пространство имен для всех тестов
{
    [TestFixture] //атрибуты 
    public class GroupCreationTests : AuthTestBase // класс должен быть уникальным
    {
        [Test]  //тестовый метод
        public void _1_GroupCreationTest() // тестовый метод дб уникальным
        {
            GroupData group = new GroupData("aaa");
            group.Header = null;
            group.Footer = null;

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }

        public static void CreateGroup(ApplicationManager app)
        {
            throw new NotImplementedException();
        }

        [Test]  //тестовый метод создает группу с пустыми именами
        public void _2_EmptyGroupCreationTest() // тестовый метод дб уникальным
        {
            GroupData group = new GroupData("aaa");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }

        [Test]  //тестовый метод для поиска бага
        public void _3_BadNameGroupCreationTest() // тестовый метод 
        {
            GroupData group = new GroupData("a'a");
            group.Header = string.Empty;
            group.Footer = string.Empty;

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count, newGroups.Count);
        }
    }
}

﻿using System;
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
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            app.Groups.Create(group);
        }

        [Test]  //тестовый метод создает группу с пустыми именами
        public void EmptyGroupCreationTest() // тестовый метод дб уникальным
        {
            GroupData group = new GroupData("aaa");
            group.Header = "";
            group.Footer = "";
            app.Groups.Create(group);
        }
    }
}
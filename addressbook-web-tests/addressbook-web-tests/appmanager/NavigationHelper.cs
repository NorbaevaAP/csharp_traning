﻿using System;
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
    public class NavigationHelper : HalperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager,string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }
        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/addressbook/")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook/addressbook/");
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void GoToMainPage()
        {
            if (driver.Url == baseURL + "/addressbook/addressbook/")
            {
                return;
            }
            driver.FindElement(By.LinkText("home page")).Click();
        }
    }
}

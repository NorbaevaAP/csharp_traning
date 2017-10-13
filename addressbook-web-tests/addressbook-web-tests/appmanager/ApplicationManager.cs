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
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;
        private bool acceptNextAlert = true;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContaktHelper contaktHelper;

        public ApplicationManager()
        {
            driver = new FirefoxDriver(new FirefoxBinary("C:\\Program Files\\Mozilla Firefox\\firefox.exe"), new FirefoxProfile());
            baseURL = "http://localhost";
            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contaktHelper = new ContaktHelper(this);

        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
                
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }
        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }
        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }
        public ContaktHelper Contakts
        {
            get
            {
                return contaktHelper;
            }
        }
    }
}

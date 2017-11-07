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
    public class ContaktHelper : HalperBase
    {
        private bool acceptNextAlert;

        public List<ContaktData> GetContaktList()
        {
            List<ContaktData> contakts = new List<ContaktData>();
            manager.Navigator.GoToHomePage();
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("tr"));
            foreach (IWebElement element in elements)
            {
                contakts.Add(new ContaktData(element.Text));
            }

            return contakts;
        }

        public ContaktHelper(ApplicationManager manager)
            : base(manager)
        {
        }
        public ContaktHelper SubmitContaktCreation()
        {
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            return this;
        }

        public ContaktHelper Modify(int v, ContaktData newData)
        {
            manager.Navigator.GoToHomePage();
            SelectContakt(v);
            InitContaktModification(v);
            FillContaktForm(newData);
            SubmitContaktModification();
            manager.Navigator.GoToMainPage();
            return this;
        }

        public ContaktHelper Remove(int v)
        {
            SelectContakt(v);
            RemoveContact();
            return this;
        }

        public ContaktHelper GoExit()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys("admin");
            return this;
        }

        public ContaktHelper FillContaktForm(ContaktData group)
        {
            Type(By.Name("firstname"), group.Firstname);
            Type(By.Name("middlename"), group.Middlename);
            Type(By.Name("lastname"), group.Lastname);
            Type(By.Name("nickname"), group.Nickname);
            Type(By.Name("title"), group.Title);
            Type(By.Name("company"), group.Company);
            Type(By.Name("address"), group.Address);
            Type(By.Name("home"), group.Home);
            Type(By.Name("mobile"), group.Mobile);
            Type(By.Name("work"), group.Work);
            Type(By.Name("fax"), group.Fax);
            Type(By.Name("email"), group.Email);
            Type(By.Name("email2"), group.Email2);
            Type(By.Name("email3"), group.Email3);
            Type(By.Name("homepage"), group.Homepage);
            Type(By.Name("address2"), group.Address2);
            Type(By.Name("phone2"), group.Phone2);
            Type(By.Name("notes"), group.Notes);
            return this;
        }

        public ContaktHelper InitNewContaktCreation()
        {
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public bool CheckAnyExsists()
        {
            try
            {
                driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + 1 + "]"));
                return true;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }


        public ContaktHelper SelectContakt(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public ContaktHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            System.Threading.Thread.Sleep(1000);
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }

        public string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }

        public bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        public ContaktHelper SubmitContaktModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContaktHelper InitContaktModification(int index)
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[" + index + "]")).Click();
            return this;
        }
    }
}

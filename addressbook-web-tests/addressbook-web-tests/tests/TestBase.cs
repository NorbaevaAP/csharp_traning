﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class TestBase
    {
        private bool acceptNextAlert = true;

        protected ApplicationManager app;

        [SetUp]

        public void SetupApplicationManager()
        {
            app = ApplicationManager.GetInstance();
        }
    }
}

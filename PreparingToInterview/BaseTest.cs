using NUnit.Framework;
using OpenQA.Selenium;
using PreparingToInterview.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterview
{
    public class BaseTest
    {
        protected IWebDriver Driver;
       

        [SetUp]
        public virtual void Init()
        {
            Driver = Settings.GetDriver();
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public virtual void Cleanup()
        {
            Driver.Quit();
        }
    }
}

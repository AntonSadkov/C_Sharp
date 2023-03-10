using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TestExercise
{
    /// <summary>
    /// Класс для управлениея тестом
    /// </summary>
    public class NavigationTest : TestBase
    {
        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Js = (IJavaScriptExecutor)Driver;
            Vars = new Dictionary<string, object>();
        }

        [TearDown]
        protected void TearDown()
        {
            Driver.Quit();
        }

        public void SiteNavigation()
        {
            Driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");
            Driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            Driver.FindElement(By.LinkText("Wikipedia")).Click();
            Driver.FindElement(By.LinkText("multilingual")).Click();
            Driver.FindElement(By.LinkText("language")).Click();
            Driver.FindElement(By.LinkText("communication")).Click();
            Driver.FindElement(By.LinkText("information")).Click();
            Driver.FindElement(By.LinkText("abstract concept")).Click();
            Driver.FindElement(By.LinkText("rules")).Click();
            Driver.FindElement(By.LinkText("philosophy of logic")).Click();
            Driver.FindElement(By.LinkText("philosophy")).Click();
        }
    }
}

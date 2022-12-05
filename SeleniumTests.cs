using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using System;

using System.Collections.ObjectModel;

using System.IO;

namespace UI_Automation_Testing

{

    public class Tests

    {

        IWebDriver driver;

        [OneTimeSetUp]

        public void Setup()

        {
            // Helps to get the path of the driver dynamically
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            //This helps to create the ChomeDriver object and executes tests on Google Chrome
            //It is also possible to provide the chromedriver.exe path dircly
            driver = new ChromeDriver(path + @"\drivers\");
        }

        [Test]

        public void verifyLogo()

        {

            driver.Navigate().GoToUrl("https://www.amazon.com/");

            Assert.IsTrue(driver.FindElement(By.Id("nav-logo-sprites")).Displayed);

            Thread.Sleep(500);

        }

        [Test]

        public void searchingItem()

        {

            driver.Navigate().GoToUrl("https://www.amazon.com/");

            Assert.IsTrue(driver.FindElement(By.Id("nav-logo-sprites")).Displayed);

            Thread.Sleep(500);

            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Iphone 14 Promax case");

            Thread.Sleep(5000);

            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(Keys.Enter);

            //SendKeys.SendWait(@"{Enter}");

        }

        [OneTimeTearDown]

        public void TearDown()

        {

            driver.Quit();

        }

    }

}
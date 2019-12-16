using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumTest
{
    class Program
    {
        IWebDriver driver = new ChromeDriver(@"D:\Drivers");
        static void Main(string[] args)
        {
           

          
        }
           [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.SelectDropDown(driver,"TitleId", "Mr.", "Id");
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautaumation", "Name");
            SeleniumSetMethods.Click(driver,"Save","Name");
        }

        [TearDown]
        public void cleanup()
        {

            driver.Close();
        }
    }

}

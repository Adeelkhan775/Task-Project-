using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tasks.Base
{

    public class Base_Class
    {
		public IWebDriver driver;
		
		[SetUp]
		public void initialization()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("https://demoqa.com/forms");
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
			driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
			}
		[TearDown]
		public void TearDown()
		{
			 driver.Quit();
		}
	}
}


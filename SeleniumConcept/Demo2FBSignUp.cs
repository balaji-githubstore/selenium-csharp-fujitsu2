using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Program2
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);

            driver.Url = "https://www.facebook.com/";

            //click on create new account
            driver.FindElement(By.LinkText("Create New Account")).Click();

            //enter first name
            driver.FindElement(By.Name("firstname")).SendKeys("bala");

            //enter lastname 
            driver.FindElement(By.Name("lastname")).SendKeys("dina");

            //enter phonenumber
            driver.FindElement(By.Name("reg_email__")).SendKeys("787878787");

            //2 Dec 2000 
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("2");

            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Dec");

            //select 2000 
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByValue("2000");

            //click on custom radio button
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            //click on sign up 
            driver.FindElement(By.Name("websubmit")).Click();

            
        }
    }
}

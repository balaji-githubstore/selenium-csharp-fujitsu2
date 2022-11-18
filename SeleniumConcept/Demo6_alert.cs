using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Programww
    {
        static void Mainw(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            //to click on Go 
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

           // Thread.Sleep(5000);
           //wait for alert is present

            string alertText= driver.SwitchTo().Alert().Text;
            Console.WriteLine(alertText);

            //driver.SwitchTo().Alert().SendKeys("hello");

            driver.SwitchTo().Alert().Accept();
        }
    }
}

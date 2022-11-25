using OpenQA.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    //using name or id as string
    public class Programw1
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://facebook.com/";

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.IgnoreExceptionTypes(typeof(Exception));
            wait.Timeout = TimeSpan.FromSeconds(20);


            //wait.IgnoreExceptionTypes(typeof(NoAlertPresentException), typeof(NoSuchElementException));
            //wait.PollingInterval = TimeSpan.FromSeconds(1);


            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            wait.Until(x => x.FindElement(By.LinkText("Create New Account"))).Click();
            wait.Until(x => x.FindElement(By.Name("firstname"))).SendKeys("bala");
            wait.Until(x => x.FindElement(By.Name("lastname"))).SendKeys("bala");

            string title = wait.Until(x => x.Title);
            Console.WriteLine(title);


            //ignore alert exception for 20s if alert is not there
            string alertText=wait.Until(x => x.SwitchTo().Alert()).Text;
            wait.Until(x => x.SwitchTo().Alert()).Accept();

            //driver.FindElement(By.LinkText("Create New Account")).Click();

            //driver.FindElement(By.Name("firstname")).SendKeys("bala");

            //driver.FindElement(By.Name("lastname")).SendKeys("dina");

            //string alertText = driver.SwitchTo().Alert().Text;
            //Console.WriteLine(alertText);

            //driver.SwitchTo().Alert().SendKeys("hello");

            //driver.SwitchTo().Alert().Accept();

        }
    }
}

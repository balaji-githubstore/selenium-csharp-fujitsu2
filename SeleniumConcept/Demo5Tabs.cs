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
    public class Programw
    {
        static void Main4(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.online.citibank.co.in/";

            //close pop up
            driver.FindElement(By.XPath("//a[@title='Close']")).Click();

            //click on APPLY FOR CREDIT CARDS
            driver.FindElement(By.LinkText("APPLY FOR CREDIT CARDS")).Click();

            //switch to 2nd tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.LinkText("Travel")).Click();
            driver.FindElement(By.Id("Email_Id")).SendKeys("Jack@gmail.com");
            //enter mobile number as 88989

            driver.Close(); //close the current session/current tab

            //switch to 1st tab
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);
            
        }
    }
}

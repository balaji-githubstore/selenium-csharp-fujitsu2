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
    public class Program2
    {
        static void Main3(string[] args)
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
            ReadOnlyCollection<string> windows= driver.WindowHandles;
            driver.SwitchTo().Window(windows[1]);

            driver.FindElement(By.LinkText("Travel")).Click();
            driver.FindElement(By.Id("Email_Id")).SendKeys("Jack@gmail.com");
            //enter mobile number as 88989

            driver.Close(); //check which tab is closed
            
        }
    }
}

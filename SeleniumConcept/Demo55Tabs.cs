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
    public class Demo55Tabs
    {
        static void Main3(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


            driver.Url = "https://www.online.citibank.co.in/";

            driver.FindElement(By.XPath("//a[@title='Close']")).Click();

            driver.FindElement(By.LinkText("APPLY FOR CREDIT CARDS")).Click();

            driver.FindElement(By.XPath("//span[text()='Login']")).Click();


            //still driver will point to 1 st tab
            //ReadOnlyCollection<string> windows = driver.WindowHandles;

            //foreach(string win in windows)
            //{
            //    //Console.WriteLine(win);
            //    driver.SwitchTo().Window(win);
            //    //Console.WriteLine(driver.Title);
            //    if(driver.Title.Equals("Citibank India"))
            //    {
            //        break;
            //    }
            //    //Console.WriteLine("---------------------");
            //}

            ReadOnlyCollection<string> windows = driver.WindowHandles;

            foreach (string win in windows)
            {
                driver.SwitchTo().Window(win);
                if (driver.Title.Equals("Citibank India"))
                {
                    break;
                }
            }

            //driver will point to the tab with title - 
            driver.FindElement(By.Id("User_Id")).SendKeys("hello");
        }
    }
}

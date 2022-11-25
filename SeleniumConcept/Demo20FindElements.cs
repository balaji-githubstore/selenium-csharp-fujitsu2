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
    public class Programww3
    {
        static void Main33(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            driver.Url = "https://www.google.com/";

            //presence of element
            if (driver.FindElements(By.XPath("//a[@title='Close']")).Count > 0)
            {
                //element should be present. it will check for visiblity
                if(driver.FindElement(By.XPath("//a[@title='Close']")).Displayed)
                {
                    driver.FindElement(By.XPath("//a[@title='Close']")).Click();
                }
                
            }



        }
    }
}

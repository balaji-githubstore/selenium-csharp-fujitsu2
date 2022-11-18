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
    //using name or id as string
    public class ProgramA
    {
        static void Main11(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://nasscom.in/";

            Actions acion = new Actions(driver);
            acion.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Perform();

            driver.FindElement(By.XPath("//a[text()='Members Listing']")).Click();


           
        }
    }
}

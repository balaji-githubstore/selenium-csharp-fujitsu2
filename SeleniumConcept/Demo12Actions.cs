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
    public class ProgramB
    {
        static void Mainv(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://nasscom.in/";

            //div[@id='navigation']/descendant::a[text()='Membership']

            //div[@id='navigation']//a[text()='Membership']

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//div[@id='navigation']//a[text()='Membership']"))).Perform();

            //mouse hover on Become a member
            action.MoveToElement(driver.FindElement(By.XPath("//div[@id='navigation']//a[text()='Become a member']"))).Perform();


            driver.FindElement(By.XPath("//a[text()='Membership Benefits']")).Click();


           
        }
    }
}

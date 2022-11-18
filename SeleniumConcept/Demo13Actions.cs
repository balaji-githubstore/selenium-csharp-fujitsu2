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
    public class ProgramC
    {
        static void MainC(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://nasscom.in/";

            //div[@id='navigation']/descendant::a[text()='Membership']

            //div[@id='navigation']//a[text()='Membership']

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//div[@id='navigation']//a[text()='Membership']")))
                .Pause(TimeSpan.FromSeconds(1))
                .MoveToElement(driver.FindElement(By.XPath("//div[@id='navigation']//a[text()='Become a member']")))
                .Build().Perform();


            driver.FindElement(By.XPath("//div[@id='navigation']//a[text()='Membership Benefits']")).Click();


           
        }
    }
}

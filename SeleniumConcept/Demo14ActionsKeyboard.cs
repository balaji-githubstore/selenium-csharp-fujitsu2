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
    public class ProgramF
    {
        static void Mainc(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://google.com/";

            //div[@id='navigation']/descendant::a[text()='Membership']

            //div[@id='navigation']//a[text()='Membership']

            Actions action = new Actions(driver);
            action.KeyDown(Keys.Shift).SendKeys("hello").KeyUp(Keys.Shift).Pause(TimeSpan.FromSeconds(1))
                .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Pause(TimeSpan.FromSeconds(1))
                 .SendKeys(Keys.Enter).Build().Perform();



            //will start at 11:30 AM IST


        }
    }
}

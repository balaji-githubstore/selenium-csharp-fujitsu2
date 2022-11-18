using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Program12
    {
        static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.goto.com/meeting";

            driver.FindElement(By.Id("truste-consent-button")).Click();

            try
            {
                Actions action = new Actions(driver);
                action.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            }
            catch(Exception ex)
            {

            }
            
            driver.FindElement(By.LinkText("Try Free")).Click();

            driver.FindElement(By.Id("first-name")).SendKeys("John");
            driver.FindElement(By.Id("last-name")).SendKeys("Wick");
            driver.FindElement(By.Id("login__email")).SendKeys("John@gmail.com");

            SelectElement selectSize = new SelectElement(driver.FindElement(By.Id("CompanySize")));
            selectSize.SelectByText("10 - 99");

            //button[@data-button='trial-submit']
            //button[text()='Start My Trial']
            //button[contains(text(),'My Trial')]
            driver.FindElement(By.XPath("//button[contains(text(),'My Trial')]")).Click();

            string actualError = driver.FindElement(By.XPath("//div[@class='inputField__requirements']")).Text;
            Console.WriteLine(actualError);


        }
    }
}

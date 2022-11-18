using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Program1
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Selenium Basics!!");

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";

            string title= driver.Title;
            Console.WriteLine(title);

            string currentUrl = driver.Url;
            Console.WriteLine(currentUrl);

            Console.WriteLine(driver.Url);
            //Console.WriteLine(driver.PageSource);



            

            By locator=By.Id("email");
            IWebElement element= driver.FindElement(locator);
            element.SendKeys("jack123@gmail.com");

            // driver.FindElement(By.Id("email")).SendKeys("jackl1233@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("welcome123");

            //click on login
            driver.FindElement(By.Name("login")).Click();

        }
    }
}

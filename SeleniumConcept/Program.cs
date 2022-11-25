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
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            driver.Url = "https://www.google.com/";

            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.XPath("//a"));

            Console.WriteLine(elements.Count);

            //for(int i=0;i<elements.Count;i++) 
            //{
            //    string innerText = elements[i].Text;
            //    Console.WriteLine(innerText);

            //    string href = elements[i].GetAttribute("href");
            //    Console.WriteLine(href);
            //}
            Console.WriteLine("---------------------");
            foreach(IWebElement ele in elements)
            {
                string innerText = ele.Text;
                Console.WriteLine(innerText);

                string href = ele.GetAttribute("href");
                Console.WriteLine(href);
            }
        }
    }
}

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
    public class Programq
    {
        static void Mainq(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\Administrator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.ilovepdf.com/pdf_to_word";

            //input[@type='file' and @accept='.pdf']
            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys("C:\\landdoc.pdf");
            
        }
    }
}

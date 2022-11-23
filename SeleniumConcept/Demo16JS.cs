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
    public class Programjs
    {
        static void Main3(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://phptravels.net/";


            //approach 1
            //driver.FindElement(By.Id("checkin")).SendKeys("07-12-2022");

            //apprach 2 - using javascript
            //document.querySelector('#checkin').value='07-12-2022'

            //document.querySelector('#checkout').value='17-12-2022'

            //  WebDriverExtensions.ExecuteJavaScript(driver, "");

            driver.ExecuteJavaScript("document.querySelector('#checkin').value='07-12-2022'");

            driver.ExecuteJavaScript("document.querySelector('#checkout').value='17-12-2022'");

            Screenshot sc = driver.TakeScreenshot();
            sc.SaveAsFile("C:\\error.png");

            //retrieve data using javascript
            string output = driver.ExecuteJavaScript<string>("return document.querySelector('#checkin').value");
            Console.WriteLine(output);
        }
    }
}

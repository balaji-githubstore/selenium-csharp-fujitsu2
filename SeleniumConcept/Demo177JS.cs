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
    public class Programrrr
    {
        static void Mainrr(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


            driver.Url = "https://www.youtube.com/watch?v=5FUdrBq-WFo";


            object output = driver.ExecuteJavaScript<object>("return document.querySelectorAll(\"[class='video-stream html5-main-video']\")[0].duration");
            Console.WriteLine(output);

            output = driver.ExecuteJavaScript<object>("return document.querySelectorAll(\"[class='video-stream html5-main-video']\")[0].currentTime");
            Console.WriteLine(output);


        }
    }
}

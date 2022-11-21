﻿using OpenQA.Selenium;
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
    public class Program8
    {
        //using WebElement
        static void Main8(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\Administrator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            //frame[contains(@src,'RSNBLogin')]
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("test123");
            driver.FindElement(By.LinkText("CONTINUE")).Click();


            //come out of frame//switch to main html
            driver.SwitchTo().DefaultContent();
            
        }
    }
}

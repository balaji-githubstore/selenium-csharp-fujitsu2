using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.DevTools;
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
    public class ProgramCSS
    {
        static void Maincs(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://demo.openemr.io/b/openemr";

            driver.FindElement(By.CssSelector("#authUser")).SendKeys("admin");
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys("pass");

            SelectElement selectLan = new SelectElement(driver.FindElement(By.CssSelector("select[name='languageChoice']")));
            selectLan.SelectByText("English (Indian)");
            driver.FindElement(By.CssSelector("#login-button")).Click();
            
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAutomation
{
    public class ZoomAppTest
    {
        WindowsDriver<WindowsElement> driver;
        DefaultWait<WindowsDriver<WindowsElement>> wait;
        [SetUp]
        public void LaunchApp()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            options.AddAdditionalCapability("platformName", "windows");
            //"C:\Windows\system32\notepad.exe"
            options.AddAdditionalCapability("app", @"C:\Users\Administrator\AppData\Roaming\Zoom\bin\Zoom.exe");

            driver = new WindowsDriver<WindowsElement>(new Uri("http://localhost:4723/wd/hub"), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
             wait = new DefaultWait<WindowsDriver<WindowsElement>>(driver);
            wait.IgnoreExceptionTypes(typeof(Exception));
            wait.Timeout = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        public void TerminateApp()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void InvalidLogin2Test()
        {
            wait.Until(x=>x.FindElement(By.XPath("//Button[@Name='Sign In']"))).Click();
            wait.Until(x => x.FindElement(By.XPath("//Edit[@Name='Enter your email']"))).SendKeys("hello1234@gm.com");
            wait.Until(x => x.FindElement(By.XPath("//Edit[@Name='Enter your password']"))).Click();
            wait.Until(x => x.FindElement(By.XPath("//Edit[@Name='Enter your password']"))).SendKeys("helcom");
            wait.Until(x => x.FindElement(By.Name("Sign In"))).Click();

            string actualError = wait.Until(x => x.FindElement(By.XPath("//Text[contains(@Name,'Incorrect')]"))).Text;

            Assert.That(actualError, Is.EqualTo("Incorrect email or password"));
        }

        [Test]
        public void InvalidLoginTest()
        {
            //Console.WriteLine(driver.PageSource);

            //driver.FindElement(By.Name("Sign In")).Click();
            driver.FindElement(By.XPath("//Button[@Name='Sign In']")).Click();

            driver.FindElement(By.XPath("//Edit[@Name='Enter your email']")).SendKeys("hello1234@gm.com");

            //approach 1 -> click and then sendkeys 
            //approcah 2- - use Actions class method to click and type..
            driver.FindElement(By.XPath("//Edit[@Name='Enter your password']")).Click();
            driver.FindElement(By.XPath("//Edit[@Name='Enter your password']")).SendKeys("hello1234");
            //driver.FindElement(By.Name("Enter your password")).SendKeys("hello1234");

            driver.FindElement(By.Name("Sign In")).Click();

            Thread.Sleep(5000); 
            string actualError=driver.FindElement(By.XPath("//Text[contains(@Name,'Incorrect')]")).Text;

         
            Assert.That(actualError, Is.EqualTo("Incorrect email or password"));
        }
    }
}

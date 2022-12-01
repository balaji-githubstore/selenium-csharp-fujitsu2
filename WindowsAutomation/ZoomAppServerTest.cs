using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Appium server automation 
namespace WindowsAutomation
{
    public class ZoomAppServerTest
    {
        WindowsDriver<WindowsElement> driver;
        DefaultWait<WindowsDriver<WindowsElement>> wait;
        AppiumLocalService service;

        [OneTimeSetUp]
        public void Init()
        {
            //buildd ser with port 4723 
           
            service=AppiumLocalService.BuildDefaultService();

            //start the appium server installed via npm with default port 
            service.Start();

            Console.WriteLine(service.IsRunning);
            Console.WriteLine(service.ServiceUrl);
        }

        [OneTimeTearDown]
        public void End()
        {
            service.Dispose();
        }


        [SetUp]
        public void LaunchApp()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            options.AddAdditionalCapability("platformName", "windows");
            //"C:\Windows\system32\notepad.exe"
            options.AddAdditionalCapability("app", @"C:\Users\Administrator\AppData\Roaming\Zoom\bin\Zoom.exe");

            driver = new WindowsDriver<WindowsElement>(service, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
             wait = new DefaultWait<WindowsDriver<WindowsElement>>(driver);
            wait.IgnoreExceptionTypes(typeof(Exception));
            wait.Timeout = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        public void TerminateApp()
        {
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

       
    }
}

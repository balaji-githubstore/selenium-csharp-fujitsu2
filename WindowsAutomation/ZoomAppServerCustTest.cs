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
    public class ZoomAppServerCustTest
    {
        WindowsDriver<WindowsElement> driver;
        DefaultWait<WindowsDriver<WindowsElement>> wait;
        AppiumLocalService service;

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [OneTimeSetUp]
        public void Init()
        {
            //buildd ser with port 8989 

            AppiumServiceBuilder builder = new AppiumServiceBuilder();
            builder.UsingAnyFreePort();
            //builder.UsingPort(8989);
            builder.WithLogFile(new FileInfo("fileInfo.log"));

            service = builder.Build();

            //start the appium server installed via npm with default port 
            service.Start();

            Console.WriteLine(service.IsRunning);
            Console.WriteLine(service.ServiceUrl);

            logger.Info("Appium server started " + service.ServiceUrl);

            logger.Info("Connected with {0}", service.ServiceUrl);
        }

        [OneTimeTearDown]
        public void End()
        {
            service.Dispose();
            logger.Info("Appium Service terminated");
            NLog.LogManager.Shutdown();
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
            logger.Info("App startedd " + driver.Capabilities);
        }

        [TearDown]
        public void TerminateApp()
        {
            driver.Quit();
            logger.Info("App terminated");
        }

        [Test]
        public void InvalidLogin2Test()
        {
            string actualError = null;
            try
            {
                wait.Until(x => x.FindElement(By.XPath("//Button[@Name='Sign In']"))).Click();
                logger.Info("Clicked on sign in");
                wait.Until(x => x.FindElement(By.XPath("//Edit[@Name='Enter your email']"))).SendKeys("hello1234@gm.com");
                logger.Info("Entered username ");
                wait.Until(x => x.FindElement(By.XPath("//Edit[@Name='Enter your password']"))).Click();
                wait.Until(x => x.FindElement(By.XPath("//Edit[@Name='Enter your password']"))).SendKeys("helcom");
                wait.Until(x => x.FindElement(By.Name("Sign In"))).Click();

                actualError = wait.Until(x => x.FindElement(By.XPath("//Text[contains(@Name,'Incorrect')]"))).Text;
                Assert.That(actualError, Is.EqualTo("Incorrect email or password"));
            }
            catch (Exception ex) {
                logger.Error(ex, "Something bad happened");
                Assert.Fail(ex.Message);
            }

            
        }

       
    }
}

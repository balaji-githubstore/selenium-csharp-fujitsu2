using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interactions;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsAutomation
{
    public class GithubTest
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
            options.AddAdditionalCapability("app", @"C:\Users\Administrator\AppData\Local\GitHubDesktop\GitHubDesktop.exe");

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
        public void GithubDesktopTest()
        {
            
            //Skip this step
            //click on skip this step
            //type name as john
            //email as john2@gmail.com
            //click on cancel

            //*[@AutomationId='__TextBox_Email']

            wait.Until(x => x.FindElement(By.Name("Skip this step"))).Click();

            wait.Until(x => x.FindElement(By.Name("Name"))).Clear();

            wait.Until(x => x.FindElement(By.Name("Name"))).Click();

          Actions actions = new Actions(driver);
            Thread.Sleep(5000);
            actions.DoubleClick().SendKeys(Keys.Backspace).Build().Perform();
            //driver.Keyboard.SendKeys(Keys.Control + "a");

            wait.Until(x => x.FindElement(By.Name("Name"))).Clear();

            wait.Until(x => x.FindElement(By.Name("Name"))).Clear();
            wait.Until(x => x.FindElement(By.Name("Name"))).Clear();

            //wait.Until(x => x.FindElement(By.Name("Name"))).SendKeys("hello1234@gm.com");

            wait.Until(x => x.FindElement(By.Name("Email"))).Click();
            wait.Until(x => x.FindElement(By.Name("Email"))).Clear();
           // wait.Until(x => x.FindElement(By.Name("Email"))).SendKeys("helcom");

          //  wait.Until(x => x.FindElement(By.Name("Cancel"))).Click();

        }
    }
}

using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace WindowsAutomation
{
    public class NotepadTest
    {
        WindowsDriver<IWebElement> driver;
        DefaultWait<WindowsDriver<IWebElement>> wait;
        [SetUp]
        public void LaunchApp()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            options.AddAdditionalCapability("platformName", "windows");
            //"C:\Windows\system32\notepad.exe"
            options.AddAdditionalCapability("app", @"C:\Windows\system32\notepad.exe");

            driver = new WindowsDriver<IWebElement>(new Uri("http://localhost:7878/wd/hub"), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            wait = new DefaultWait<WindowsDriver<IWebElement>>(driver);
            wait.IgnoreExceptionTypes(typeof(Exception));
            wait.Timeout = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        public void TerminateApp()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }


        [Test]
        public void NotePad1Test()
        {
            //Console.WriteLine(driver.PageSource);

            driver.FindElement(By.XPath("//*[@Name='Text Editor']")).SendKeys("hello");
            driver.FindElement(By.XPath("//MenuItem[@Name='File']")).Click();
            driver.FindElement(By.XPath("//MenuItem[contains(@Name,'Save As')]")).Click();

            driver.FindElement(By.XPath("//Edit[contains(@Name,'File na')]")).Clear();
            driver.FindElement(By.XPath("//Edit[contains(@Name,'File na')]")).SendKeys(@"C:\demo.txt");
            driver.FindElement(By.XPath("//Button[@Name='Save']")).Click();
        }

        [Test]
        public void CollectAllMenuTest()
        {
            //Use FindElements and collect all menu and print
            ReadOnlyCollection<IWebElement> elements= driver.FindElements(By.XPath("//MenuItem"));

            for(int i=0;i<elements.Count;i++)
            {
                Console.WriteLine(elements[i].Text);
            }     

        }

        [Test]
        public void Collect2AllMenuTest()
        {
            //Use FindElements and collect all menu and print
            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.XPath("//MenuItem"));

            foreach (IWebElement ele in elements)
            {
                Console.WriteLine(ele.Text);
            }

        }

       

        [Test]
        public void Collect4AllMenuTest()
        {
            //Use FindElements and collect all menu and print
            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.XPath("//MenuItem"));

            foreach (IWebElement ele in elements)
            {
                if(ele.Text.ToLower().Equals("view"))
                {
                    ele.Click();
                    break;
                }
            }

        }

        [Test]
        public void Collect5AllMenuTest()
        {
            ClickByText("format");
            ClickByText("Font...");
            driver.FindElement(By.XPath("//ComboBox[@Name='Script:']")).Click();
            //ClickByText("Greek");

          
        }

        [Test]
        public void Collect6AllMenuTest()
        {
            ClickByText("format");
            ClickByText("Font...");
            driver.FindElement(By.XPath("//ComboBox[@Name='Script:']")).Click();
            //ClickByText("Greek");
            Thread.Sleep(5000);
            Console.WriteLine(driver.FindElements(By.XPath("//ComboBox[@Name='Script:']//ListItem[@Name='Baltic']")).Count);

            Thread.Sleep(5000);
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            options.AddAdditionalCapability("platformName", "windows");
            //"C:\Windows\system32\notepad.exe"
            options.AddAdditionalCapability("app", "root");

            driver = new WindowsDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), options);

            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//ComboBox[@Name='Script:']//ListItem[@Name='Baltic']")).Click();

        }
        //will start at 11:35 AM IST
        public void ClickByText(string text)
        {
            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.XPath("//MenuItem"));

            foreach (IWebElement ele in elements)
            {
                if (ele.Text.ToLower().Equals(text.ToLower()))
                {
                    ele.Click();
                    break;
                }
            }
        }

        [Test]
        public void NotePad123Test()
        {
            Console.WriteLine(driver.PageSource);

            Thread.Sleep(5000);
            Actions action = new Actions(driver);
            //action.KeyDown(Keys.Shift).KeyUp(Keys.Shift)
            action.SendKeys("hello").Build().Perform();
            
            
            //action.MoveToElement(driver.FindElement(By.XPath("//*[@Name='File']"))).Build().Perform();
        }

        [Test]
        public void GithubDesktopTest()
        {

        }
    }
}

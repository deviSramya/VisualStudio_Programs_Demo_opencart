using opencart_001.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace opencart_001
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            /* driver.Navigate().GoToUrl("https://demo.opencart.com/");
              driver.FindElement(By.LinkText("My Account")).Click();
              driver.FindElement(By.LinkText("Login")).Click();
              driver.FindElement(By.Id("input-email")).SendKeys("aaa@gmail.com");
              driver.FindElement(By.Id("input-password")).SendKeys("wel123");
              driver.FindElement(By.XPath("//button[@type='submit']")).Click();*/


            pageobject_login lp = new pageobject_login(driver);
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            lp.clickonmyaccountlink();
            lp.clickregisterlink();
            // lp.clickonloginlink();
            lp.enterfirstname();
            lp.enterlastname();
            lp.enterusername();
            lp.enterpassword();
            lp.clicksubmit();

            driver.Quit();
            Assert.Pass();
        }
    }
}
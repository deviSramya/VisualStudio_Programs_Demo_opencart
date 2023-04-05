using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opencart_001.pages
{
    
    internal class pageobject_login
        
    {
       private IWebDriver driver;

        public pageobject_login(IWebDriver driver1) {
            driver = driver1;
        
        }
        public void clickonmyaccountlink()
        {
            driver.FindElement(By.LinkText("My Account")).Click();
        }
      /*  public void clickonloginlink()
        {
            driver.FindElement(By.LinkText("Login")).Click();
        }*/
      public void clickregisterlink()
        {
            driver.FindElement(By.LinkText("Register")).Click();
        }
        public void enterfirstname()
        {
            driver.FindElement(By.Id("input-firstname")).SendKeys("anu");
        }
        public void enterlastname() 
        {
            driver.FindElement(By.Id("input-lastname")).SendKeys("sha");
        }
        public void enterusername()
        {
            driver.FindElement(By.Id("input-email")).SendKeys("aaa@gmail.com");
        }
        public void enterpassword()
        {
            driver.FindElement(By.Id("input-password")).SendKeys("wel123");
        }
        public void clicksubmit()
        {
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

    }
}

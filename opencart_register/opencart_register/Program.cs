using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace opencart_register
{
    internal class Program
    {
        static void Main(string[] args)
        {

            excel.Application xlapp = new excel.Application();
            excel.Workbook xwb = xlapp.Workbooks.Open("C:\\selenium\\pydemo2.xlsx");
            excel.Worksheet xws = xwb.Sheets[1];
            excel.Range r1 = xws.UsedRange;
            Console.WriteLine(r1);

            for (int i = 1; i <= 5; i++)
            {
                String nameone, nametwo, username, password;
                nameone = r1.Cells[1][i].value;
                nametwo = r1.Cells[2][i].value;
                username = r1.Cells[3][i].value;
                password = r1.Cells[4][i].value;
                Console.WriteLine(nameone);
                Console.WriteLine(nametwo);
                Console.WriteLine(username);
                Console.WriteLine(password);


                Console.WriteLine("Hello world welcome to c#");
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://demo.opencart.com/");
                driver.FindElement(By.LinkText("My Account")).Click();
                driver.FindElement(By.LinkText("Register")).Click();
                driver.FindElement(By.Id("input-firstname")).SendKeys(nameone);
                driver.FindElement(By.Id("input-lastname")).SendKeys(nametwo);
                driver.FindElement(By.Id("input-email")).SendKeys(username);
                driver.FindElement(By.Id("input-password")).SendKeys(password);
                driver.FindElement(By.XPath("//*[@id=\"input-newsletter-yes\"]")).Click();
                driver.FindElement(By.XPath("//*[@id=\"form-register\"]/div/div/div/input")).Click();
                driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                driver.Quit();
            }
        }

       
    }
}

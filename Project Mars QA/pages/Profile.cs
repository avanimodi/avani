using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Project_Mars_QA.pages
{
    public class Profile
    {
        public void profileTab(IWebDriver driver)
        {
            Thread.Sleep(2000);
            // profile page 
            IWebElement profilePage = driver.FindElement(By.XPath("//div/section[1]/div/a[2]\r\n"));
            profilePage.Click();
            Thread.Sleep(2000);
        }
        
    }
}

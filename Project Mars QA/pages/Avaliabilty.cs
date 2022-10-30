using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Project_Mars_QA.pages
{
   public class Avaliabilty
    {
        public void createAvaliabilty(IWebDriver driver)

        {
            //Thread.Sleep(2000);
            //IWebElement profileTab = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[1]/div/a[2]"));
            //profileTab.Click();

          Thread.Sleep(2000);
            // availability                                    
            IWebElement availability = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            
            availability.Click();
            Thread.Sleep(2000);
            // Availability drop box
            IWebElement availabilityDropBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            availabilityDropBox.SendKeys("Full Time");
            Thread.Sleep(2000);

        }

        public string GetActualAvailability(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement newAvailability = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            return newAvailability.Text;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Project_Mars_QA.pages
{
   public class Skills
    {
        public void skillstabClick(IWebDriver driver)
        {
            IWebElement skills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skills.Click();

        }

        public void createSkills(IWebDriver driver)
        {
            // go to skills 
            IWebElement skills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skills.Click();
            Thread.Sleep(2000);

            //add new button in Skills (Create)
            IWebElement addNewSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewSkills.Click();
            Thread.Sleep(2000);

            //add Skills in textbox (Create)
            IWebElement addSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkills.SendKeys("abc");
            Thread.Sleep(2000);

            //choose skills in dropbox (Create)
            IWebElement chooseSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            chooseSkills.SendKeys("Expert");
            Thread.Sleep(2000);

            // add button in skills (Create)
            IWebElement add = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            add.Click();
            Thread.Sleep(2000);

        }


            //// check record has been create successfully

            //IWebElement newSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            //IWebElement newSkillsLevels = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));


            //Assert.That(newSkills.Text == "abc", "acual skills has been created successfully");
            //Assert.That(newSkillsLevels.Text == "Expert", "acual skills levels has been created successfully");
           
            
            public string GetActualSkills(IWebDriver driver)
            {
            IWebElement newSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newSkills.Text;
            }



        public void editSkills(IWebDriver driver)

        {
            //Click on Skills button
            IWebElement skills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skills.Click();

            // edit icone in skills
            IWebElement editIconeSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editIconeSkills.Click();
            Thread.Sleep(2000);

            // edit  skills (edit)
            IWebElement editSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editSkills.Clear();
            editSkills.SendKeys("aaa");
            Thread.Sleep(2000);

            //edit skills levels dropbox (edit)
            IWebElement editSkillsLevels = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            editSkillsLevels.SendKeys("Beginner");
            Thread.Sleep(2000);

            // update button in Skills (edit)
            IWebElement updateButtonSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButtonSkills.Click();
            Thread.Sleep(2000);

        }

            //// check edit skills has been edited successfully 

            //IWebElement newEditSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            //IWebElement newEditSkillsLevels = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));

            //Assert.That(newEditSkills.Text == "aaa", "acual skills has been edited successfully");
            //Assert.That(newEditSkillsLevels.Text == "Beginner", "acual skills levels has been edited successfully ");

            public string GetUpdatedSkills(IWebDriver driver)
            {
                IWebElement updatedSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
                return updatedSkills.Text;
            }


        
        public void deleteSkills(IWebDriver driver)
        {

            IWebElement skills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skills.Click();
            Thread.Sleep(2000);

            //delete button in skills (delete)
            IWebElement deleteIconeSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteIconeSkills.Click();
        }
                       
           
        public string GetDeleteSkills(IWebDriver driver)
        {

            IWebElement newDeleteIcon = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return  null;
        
        }


    }
}

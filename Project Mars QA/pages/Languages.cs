using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Project_Mars_QA.pages
{
    public class Languages
    {


        public void languagetabClick(IWebDriver driver)
        {
            IWebElement language = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            language.Click();

        }
        public void createLan(IWebDriver driver)
        {

            Thread.Sleep(2000);

            //add new button in langueges (create)
            IWebElement addNewlangueges = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
          
            addNewlangueges.Click();
            Thread.Sleep(2000);
           
            //add langueges in textbox (create)
            IWebElement addLangueges = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLangueges.SendKeys("English");
            Thread.Sleep(2000);

            //choose langueges in dropbox (create)
            IWebElement chooseLangueges = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLangueges.SendKeys("Fluent");
            Thread.Sleep(2000);

            // add button in languages (create)
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(2000);
        }



        // check record is present or not in langueges

        // IWebElement newLang = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        // IWebElement newLangLevels = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));

        //Assert

        //Assert.That(newLang.Text == "English", "acual languages did not match");
        //Assert.That(newLangLevels.Text == "Fluent", "acual lan levels did not match");

        public string GetActualLanguage(IWebDriver driver)
        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newLanguage.Text;
        }
        
    

       


        public void editLan(IWebDriver driver)
        {
            // edit icon in langauges (edit)
            IWebElement editIcon = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editIcon.Click();
            Thread.Sleep(2000);

            // edit langueges textbox (edit)
            IWebElement editLangueges = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editLangueges.Clear();
            editLangueges.SendKeys("Hindi");
            Thread.Sleep(2000);

            //edit langueges levels dropbox (edit)
            IWebElement editLanLevel = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            editLanLevel.SendKeys("Basic");
            Thread.Sleep(2000);

            // update button in languages (edit)
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();
            Thread.Sleep(2000);




            //check record is present or not in skills 

            //IWebElement newEditLang = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            // IWebElement newEditLanLevels = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));


            // Assert.That(newEditLang.Text == "Hindi", "acual languages did not match");
            // Assert.That(newEditLanLevels.Text == "Basic", "acual languages levels did not match");

        }

        //public string GetUpdatedLanguage(IWebDriver driver,String Langueges)
        public string GetUpdatedLanguage(IWebDriver driver)
        {
            IWebElement UpdatedLanguage = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return UpdatedLanguage.Text;
        }
        public string GetUpdatedLevel(IWebDriver driver)
        {
            IWebElement UpdatedLevel = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return UpdatedLevel.Text;
        }



        public void deleteLan(IWebDriver driver)
        {

            IWebElement language = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            language.Click();

            //delete button in languages (delete)
            IWebElement deleteIcone = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteIcone.Click();
        }

        public string GetDeletelanguages(IWebDriver driver)

            {

                IWebElement newDeleteIcon = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
                return null;

            }


        }

    }

    


using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Project_Mars_QA.pages;
using Project_Mars_QA.uitlies;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Project_Mars_QA
{
    [Binding]
    public class SkillsStepDefinitions : CommanDriver
    {
        IWebDriver driver = new ChromeDriver();
        login loginPageobj = new login();
        Skills Skillsobj = new Skills();

        //create

        [Given(@"I login to the mars website")]
        public void GivenILoginToTheMarsWebsite()
        {
            Thread.Sleep(2000);
            loginPageobj.loginSteps(driver);

           
        }

        [When(@"I navigate skills in profile page")]
        public void WhenINavigateSkillsInProfilePage()
        {
            Profile Profileobj = new Profile();
            Profileobj.profileTab(driver);
            Skillsobj.skillstabClick(driver);
        }
        [When(@"I create credential in skill")]
        public void WhenICreateCredentialInSkill()
        {
            
            Skillsobj.createSkills(driver);
        }
        [Then(@"skill should be created  successfully")]
        public void ThenSkillShouldBeCreatedSuccessfully()
        {
           
            string newSkill = Skillsobj.GetActualSkills(driver);
            Assert.That(newSkill == "abc", "acual skills has been created successfully");
           
        }

        //Edit

        [Given(@"I login to the  website")]
        public void GivenILoginToTheWebsite()
        {

            loginPageobj.loginSteps(driver);
        }

        [When(@"I navigate skills in the profile page")]
        public void WhenINavigateSkillsInTheProfilePage()
        {
            Profile Profileobj = new Profile();
            Profileobj.profileTab(driver);
        }

        [When(@"I edit '([^']*)'credential in skills")]
        public void WhenIEditCredentialInSkills(string skill)
        {
            Skills Skillsobj = new Skills();
            Skillsobj.editSkills(driver);
        }

        [Then(@"Skill should be edited successfully in '([^']*)'")]
        public void ThenSkillShouldBeEditedSuccessfullyIn(string skill)
        {
            Skills Skillsobj = new Skills();
            string updatedSkills = Skillsobj.GetUpdatedSkills(driver);
            Assert.That(updatedSkills == "aaa", "acual skills has been edited successfully");
        }

        //Delete

        [Given(@"I login to website")]
        public void GivenILoginToWebsite()
        {
          
            loginPageobj.loginSteps(driver);
        }


        [When(@"I navigate skills in the profile")]
        public void WhenINavigateSkillsInTheProfile()
        {
            Profile Profileobj = new Profile();
            Profileobj.profileTab(driver);
        }


        [When(@"I delete credential in skill")]
        public void WhenIDeleteCredentialInSkill()
        {

            Skills Skillsobj = new Skills();
            Skillsobj.deleteSkills(driver);
        }
        [Then(@"skill should be deleted successfully")]
        public void ThenSkillShouldBeDeletedSuccessfully()
        {
            Skills Skillsobj = new Skills();
            string GetDeleteSkills = Skillsobj.GetDeleteSkills(driver);
            Assert.That(GetDeleteSkills != "aaa", "acual skills has been edited successfully");
        }






    }
}

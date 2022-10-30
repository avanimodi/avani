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
    public class LanguagesStepDefinitions : CommanDriver
    {

        IWebDriver driver = new ChromeDriver();
        login loginPageobj = new login();
        Languages Languagesobj = new Languages();

        [Given(@"I loggedin to the website")]
        public void GivenILoggedinToTheWebsite()
        {

            loginPageobj.loginSteps(driver);

        }

        [When(@"I navigate Language in the profile page")]
        public void WhenINavigateLanguageInTheProfilePage()
        {
            Profile Profileobj = new Profile();
            Profileobj.profileTab(driver);
            Languagesobj.languagetabClick(driver);

        }

        [When(@"I create credential in the Language")]
        public void WhenICreateCredentialInTheLanguage()
        {

            Languagesobj.createLan(driver);

        }

        [Then(@"Language should be created successfully")]
        public void ThenLanguageShouldBeCreatedSuccessfully()
        {

            string newLanguage = Languagesobj.GetActualLanguage(driver);
            Assert.That(newLanguage == "English", "acual languages did not match");
        }


        //Edit

        [Given(@"I loggedin to the Mars website")]
        public void GivenILoggedinToTheMarsWebsite()
        {

            loginPageobj.loginSteps(driver);

        }

        [When(@"I navigate Language in profile page")]
        public void WhenINavigateLanguageInProfilePage()
        {

            Profile Profileobj = new Profile();
            Profileobj.profileTab(driver);

        }


        [When(@"I Edit '([^']*)' credential in profile page")]
        public void WhenIEditCredentialInProfilePage(string hindi)
        {
            Languages Languagesobj = new Languages();
            Languagesobj.editLan(driver);
        }

        [Then(@"Record should be edited successfully '([^']*)'")]
        public void ThenRecordShouldBeEditedSuccessfully(string hindi)
        {
            Languages Languagesobj = new Languages();

            string newEditLang = Languagesobj.GetUpdatedLanguage(driver).ToString();
            Assert.That(newEditLang == "Hindi", "acual languages did not match");


        }

        //Delete

        [Given(@"I login to localhost website")]
        public void GivenILoginToLocalhostWebsite()
        {
            loginPageobj.loginSteps(driver);

        }

        [When(@"I navigate language in  profile")]
        public void WhenINavigateLanguageInProfile()
        {
            Profile Profileobj = new Profile();
            Profileobj.profileTab(driver);
        }

        [When(@"I deleted credential in language")]
        public void WhenIDeletedCredentialInLanguage()
        {
            Languages Languagesobj = new Languages();
            Languagesobj.deleteLan(driver);

        }
        [Then(@"language should be delete successfully")]
        public void ThenLanguageShouldBeDeleteSuccessfully()
        {
            Languages Languagesobj = new Languages();
            string GetDeleteLanguages = Languagesobj.GetDeletelanguages(driver);
            Assert.That(GetDeleteLanguages != "Hindi", "acual skills has been edited successfully");

        }


    }
}

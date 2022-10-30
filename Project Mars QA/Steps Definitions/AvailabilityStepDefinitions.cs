using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Project_Mars_QA.uitlies;
using TechTalk.SpecFlow;
using Project_Mars_QA.pages;
using NUnit.Framework;

namespace Project_Mars_QA;

[Binding]
public class AvailabilityStepDefinitions : CommanDriver
{
    IWebDriver driver = new ChromeDriver();
    login loginPageobj = new login();
    Profile Profileobj = new Profile();
    Avaliabilty Avaliabiltyobj = new Avaliabilty();

    [Given(@"I login to the website")]
    public void GivenILoginToTheWebsite()
    {
       
        loginPageobj.loginSteps(driver);



    }

    [When(@"I navigate Availability in profile page")]
    public void WhenINavigateAvailabilityInProfilePage()
    {
       
        Profileobj.profileTab(driver);


    }

    [When(@"I  update credential in Availability")]
    public void WhenIUpdateCredentialInAvailability()
    {
      
        Avaliabiltyobj.createAvaliabilty(driver);
    }

    [Then(@"Availability should be updated  successfully")]
    public void ThenAvailabilityShouldBeUpdatedSuccessfully()
    {
        string newAvailability = Avaliabiltyobj.GetActualAvailability(driver);
        Assert.That(newAvailability == "Full Time", "acual languages did not match");
    }
}

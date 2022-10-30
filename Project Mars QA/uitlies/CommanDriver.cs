using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project_Mars_QA.pages;

namespace Project_Mars_QA.uitlies
{
    public class CommanDriver
    {
        public IWebDriver driver;

        login loginPageobj = new login();
        [SetUp]
        public void LoginActions()
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();


            // login page obj
           
            loginPageobj.loginSteps(driver);

        }


            [TearDown]
            public void closeTestRun()
            {
                driver.Quit();
            }
        


    }
}

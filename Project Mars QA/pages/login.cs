
using NUnit.Framework;
using OpenQA.Selenium;

namespace Project_Mars_QA.pages
{
    public class login
    {
        public void loginSteps(IWebDriver driver)
        {
        // lunch the local host
        driver.Navigate().GoToUrl("http://localhost:5000");
        Thread.Sleep(2000);
            
         // sign in
         IWebElement signIn = driver.FindElement(By.XPath("//*[@id=\'home\']/div/div/div[1]/div/a"));
         signIn.Click();
         Thread.Sleep(2000);

         // email text box
         IWebElement emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        emailTextbox.SendKeys("avanimodi4@gmail.com");
        Thread.Sleep(2000);

         // password
        IWebElement passWord = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        passWord.SendKeys("Avanironak123");
        Thread.Sleep(2000);

        // login button
        IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        loginButton.Click();
        Thread.Sleep(2000);

        }

    }
}

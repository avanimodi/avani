using System;

public class homePage
{
	public void goToTMPage()
	{
        IWebElement adminisrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        adminisrationTab.Click();

        IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        tmOption.Click();

    }
}

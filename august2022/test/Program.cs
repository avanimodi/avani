using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open the micrpsoftEdge  browser
IWebDriver driver = new ChromeDriver();


//check if user has logged in successfully
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (hellohari.Text == "hello hari")
{
    Console.WriteLine("logged in succeesfull");
}
else 
{
    Console.WriteLine("logged in failed");
}




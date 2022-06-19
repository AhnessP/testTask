using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace TestTask;
using NUnit.Framework; 

public class Tests
{
    private IWebDriver driver;
    
  

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://rozetka.com.ua");
        driver.Manage().Window.Maximize();
        driver.FindElement(By.XPath("//input[@name='search']")).SendKeys("MD506Z/A");
        driver.FindElement(By.XPath("//button[contains(text(),'Найти')]")).Click();
        Thread.Sleep(3000);
        
        driver.FindElement(By.XPath("//button[@class='buy-button button button--with-icon button--green button--medium ng-star-inserted']")).Click();
        Thread.Sleep(3000);
        driver.FindElement(By.XPath("//button[@class='modal__close']")).Click();
        Thread.Sleep(3000);
        driver.FindElement(By.XPath("//img[@alt='Rozetka Logo']")).Click();
        Thread.Sleep(3000);
        driver.FindElement(By.XPath("//button[@class='header__button ng-star-inserted header__button--active']")).Click();
        Thread.Sleep(3000);
        driver.FindElement(By.XPath("//a[@class='cart-product__title)")).Click();









    }
    

    [Test]
    
    public void Test1()
    {


    }

    [TearDown]
    public void TearDown()
    {
        
    }
}

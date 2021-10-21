using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Guru99Proj1;
public class Tests
{
    IWebDriver _driver;

    [SetUp]
    public void Setup()
    {
        _driver = new FirefoxDriver();
    }

    [Test]
    public void Test1()
    {
        _driver.Navigate().GoToUrl("http://live.techpanda.org");
    }
}
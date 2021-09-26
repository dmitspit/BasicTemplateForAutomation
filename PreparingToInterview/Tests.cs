using NUnit.Framework;

namespace PreparingToInterview
{
    public class Tests : BaseTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/");   
        }
    }
}
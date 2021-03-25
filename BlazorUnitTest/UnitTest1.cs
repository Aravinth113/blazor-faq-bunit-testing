using NUnit.Framework;
using Bunit;
namespace BlazorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using var context = new Bunit.TestContext();
            // Act 
            var cut = context.RenderComponent<BlazorServerApp.Pages.Index>();
            cut.Find("button").Click();
            // Assert 
            cut.Find("h5").MarkupMatches("<h5>Blazor component is clicked.</h5>");
        }
    }
}
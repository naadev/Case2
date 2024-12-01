using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace calculator.frontend.tests.steps
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public CalculatorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"the first number is (.*)")]
        public async Task GivenTheFirstNumberIs(int number1)
        {
            IPage page = _scenarioContext.Get<IPage>("page");
            var base_url = _scenarioContext.Get<string>("base_url");
            await page.GotoAsync($"https://{base_url}/Calculator");
            await page.FillAsync("#firstNumber", number1.ToString());
        }

        [Given(@"the second number is (.*)")]
        public async Task GivenTheSecondNumberIs(int number2)
        {
            IPage page = _scenarioContext.Get<IPage>("page");
            await page.FillAsync("#secondNumber", number2.ToString());
        }

        [When(@"the two numbers are added")]
        public async Task WhenTheTwoNumbersAreAdded()
        {
            var page = (IPage)_scenarioContext["page"];
            await page.SelectOptionAsync("#operation", "Add");
            await page.ClickAsync("#calculateButton");
        }

        [When(@"I substract first number to second number")]
        public async Task WhenISubstractFirstNumberToSecondNumber()
        {
            var page = (IPage)_scenarioContext["page"];
            await page.SelectOptionAsync("#operation", "Subtract");
            await page.ClickAsync("#calculateButton");
        }
        [Then(@"the result should be (.*)")]
        [Then(@"the result is (.*)")]
        public async Task ThenTheResultShouldBe(string expectedResult)
        {
            var page = (IPage)_scenarioContext["page"];
            var resultText = await page.InnerTextAsync("#result");
            Assert.Equal(expectedResult, resultText);
        }
    }
}

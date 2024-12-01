using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace calculator.frontend.tests.steps
{
    [Binding]
    public class PrimeNumberSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public PrimeNumberSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"number (.*) is checked")]
        //public async Task WhenNumberIsChecked(int number)
        public void WhenNumberIsChecked(int number)
        {
            _scenarioContext.Pending();
        }

        [Then(@"the answer to know whether is prime or not is (.*)")]
        //public async Task ThenTheAnswerToKnowWhetherIsPrimeOrNotIs(string isPrime)
        public void ThenTheAnswerToKnowWhetherIsPrimeOrNotIs(string isPrime)
        {
            _scenarioContext.Pending();
        }
    }
}

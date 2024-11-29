using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace calculator.lib.test.steps
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
        public void WhenNumberIsChecked(int number)
        {
            _scenarioContext.Pending();
        }

        [Then(@"the answer to know whether is prime or not is No")]
        public void ThenTheAnswerToKnowWhetherIsPrimeOrNotIsNo()
        {
            _scenarioContext.Pending();
        }

        [Then(@"the answer to know whether is prime or not is Yes")]
        public void ThenTheAnswerToKnowWhetherIsPrimeOrNotIsYes()
        {
            _scenarioContext.Pending();
        }
    }
}

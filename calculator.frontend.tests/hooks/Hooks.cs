using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace calculator.frontend.tests.hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        public Hooks(ScenarioContext scenarioContext) 
        {
            _scenarioContext = scenarioContext;
        }
        [BeforeScenario]
        public async Task PrepareScenario()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true 
            });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();
            _scenarioContext.Add("page",page);
            _scenarioContext.Add("base_url", "calculator-frontend-master-ugr.azurewebsites.net");
            //_scenarioContext.Add("base_url", "localhost:7297");
        }
    }
}

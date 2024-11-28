﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace calculator.lib.test
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PrimeNumberFeature : object, Xunit.IClassFixture<PrimeNumberFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PrimeNumber.feature"
#line hidden
        
        public PrimeNumberFeature(PrimeNumberFeature.FixtureData fixtureData, calculator_lib_test_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "PrimeNumber", "\tAs Alice (the customer)\r\n\tI want to know whether a number is prime or not\r\n\tSo I" +
                    " can create discount campaings", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Checking several prime numbers")]
        [Xunit.TraitAttribute("FeatureTitle", "PrimeNumber")]
        [Xunit.TraitAttribute("Description", "Checking several prime numbers")]
        [Xunit.InlineDataAttribute("1", "No", new string[0])]
        [Xunit.InlineDataAttribute("2", "Yes", new string[0])]
        [Xunit.InlineDataAttribute("1", "No", new string[0])]
        [Xunit.InlineDataAttribute("2", "Yes", new string[0])]
        [Xunit.InlineDataAttribute("3", "Yes", new string[0])]
        [Xunit.InlineDataAttribute("4", "No", new string[0])]
        [Xunit.InlineDataAttribute("5", "Yes", new string[0])]
        [Xunit.InlineDataAttribute("6", "No", new string[0])]
        [Xunit.InlineDataAttribute("7", "Yes", new string[0])]
        [Xunit.InlineDataAttribute("8", "No", new string[0])]
        [Xunit.InlineDataAttribute("9", "No", new string[0])]
        [Xunit.InlineDataAttribute("10", "No", new string[0])]
        [Xunit.InlineDataAttribute("11", "Yes", new string[0])]
        [Xunit.InlineDataAttribute("997", "Yes", new string[0])]
        [Xunit.InlineDataAttribute("98689", "Yes", new string[0])]
        [Xunit.InlineDataAttribute("86743", "Yes", new string[0])]
        public void CheckingSeveralPrimeNumbers(string number, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("number", number);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checking several prime numbers", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.When(string.Format("number {0} is checked", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.Then(string.Format("the answer to know whether is prime or not is {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PrimeNumberFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PrimeNumberFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

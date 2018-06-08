using System;
using TechTalk.SpecFlow;
using HP.LFT.SDK.Web;

namespace LeanFtTestProject7
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculators")]
        public void GivenIHaveEnteredIntoTheCalculators(int p0)
        {
            //  ScenarioContext.Current.Pending();
            var browser = BrowserFactory.Launch(BrowserType.Chrome);

        }
        
        [When(@"I press addd")]
        public void WhenIPressAddd()
        {
         //   ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screeb")]
        public void ThenTheResultShouldBeOnTheScreeb(int p0)
        {
         //   ScenarioContext.Current.Pending();
        }
    }
}

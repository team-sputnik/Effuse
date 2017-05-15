using TechTalk.SpecFlow;

namespace Effuse.UI.Tests
{
    [Binding]
    public sealed class HttpLinksSteps
    {
        [When(@"I send a message with a HTTP address")]
        public void WhenISendAMessageWithAHTTPAddress()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I receive a messate with a HTTP address")]
        public void WhenIReceiveAMessateWithAHTTPAddress()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i click the address")]
        public void WhenIClickTheAddress()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the HTTP address is marked as a hyperlink")]
        public void ThenTheHTTPAddressIsMarkedAsAHyperlink()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the http address is stored in the reminder tab")]
        public void ThenTheHttpAddressIsStoredInTheReminderTab()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The address is marked as visited")]
        public void ThenTheAddressIsMarkedAsVisited()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

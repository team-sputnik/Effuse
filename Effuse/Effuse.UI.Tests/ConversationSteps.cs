using TechTalk.SpecFlow;

namespace Effuse.UI.Tests
{
    [Binding]
    public sealed class ConversationSteps
    {
        [Then(@"The message is sent")]
        public void ThenTheMessageIsSent()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

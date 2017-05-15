using TechTalk.SpecFlow;

namespace Effuse.UI.Tests
{
    [Binding]
    public sealed class CommonBindings
    {
        [Given(@"I am in a conversation")]
        public void GivenIAmInAConversation()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

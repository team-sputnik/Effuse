using System.Collections.Generic;
using Effuse.Dal;
using Effuse.Services.Tests.TestObjects;
using Moq;
using TechTalk.SpecFlow;

namespace Effuse.Services.Tests
{
    [Binding]
    public sealed class ConversationSteps
    {
        private Mock<IDataAccess> _mockDb;
        private ConversationService _conversationService;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _mockDb = new Mock<IDataAccess>();
            _conversationService = new ConversationService();
        }

        [AfterScenario]
        public void AfterScenario()
        {
        }

        [Given(@"Another user exists")]
        public void GivenAnotherUserExists()
        {
            _mockDb.Setup(t => t.GetUser(1))
                .Returns(TestUsers.ExistingUser);
        }

        [When(@"I start a conversation with another user")]
        public void StartConversationWithUser()
        {
            var conversation = _conversationService.CreateConversation(
                new List<int>
                {
                    TestUsers.NewUser.Id,
                    TestUsers.ExistingUser.Id
                });

            ScenarioContext.Current["CurrentConversation"] = conversation.conversationId;
        }

        [Then(@"A conversation is started")]
        public void AssertConversationCreated()
        {
            //Test conversation was created
            _mockDb.Verify(c => c.GetConversation(
                It.Is<int>(
                    i => i == (int)ScenarioContext.Current["CurrentConversation"])));
        }
    }
}

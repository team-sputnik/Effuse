using System.Collections.Generic;
using Effuse.Models;

namespace Effuse.Services
{
    public interface IConversationService
    {
        Conversation CreateConversation(List<int> participantIds);
    }
}

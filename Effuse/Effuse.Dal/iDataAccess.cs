using System.Collections.Generic;
using Effuse.Models;

namespace Effuse.Dal
{
    public interface IDataAccess
    {
        User GetUser(int userid);

        Conversation GetConversation(int conversationId);
    }
}

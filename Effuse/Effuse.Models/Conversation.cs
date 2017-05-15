using System;
using System.Collections.Generic;

namespace Effuse.Models
{
    public class Conversation
    {
        private List<User> _participants;
        private List<Message> _messages;
        public int conversationId { get; private set; }

        public Conversation(Message message, List<User> participants)
        {
            _participants = participants;
            _messages = new List<Message> {message};
        }

        public void AddMessage(string message)
        {
            _messages.Add(new Message
            {
                Content = message,
                TimeStamp = new DateTime()
            });
        }

        public void SetParticipants(List<int> participantIds)
        {
            
        }

    }
}

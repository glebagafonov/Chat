using System.Collections.Generic;

namespace Chat.Domain.Domain.Entity
{
    public class Channel
    {
        public User Owner                    { get; set; }
        public ICollection<User> Users       { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
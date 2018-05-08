using System;

namespace Chat.Domain.Domain.Entity
{
    public class Message : Entity
    {
        public User User   { get; set; }
        public String Text { get; set; }
    }
}
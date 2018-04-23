using System;

namespace Chat.Domain.Domain.Entity
{
    public class User : Entity
    {
        public String Email      { get; set; }
        public String Password   { get; set; }
        public DateTime DateTime { get; set; }
        public UserInfo UserInfo { get; set; }
    }
}
using System;

namespace Chat.Domain.Domain.Entity
{
    public class UserInfo : Entity
    {
        public String Name  { get; set; }
        public String Phone { get; set; }
        public String Bio   { get; set; }
    }
}
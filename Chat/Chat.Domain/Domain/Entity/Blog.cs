using System;
using System.Collections.Generic;

namespace Chat.Domain.Domain.Entity
{
    public class Blog : Entity
    {
        public User User               { get; set; }
        public String Name             { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
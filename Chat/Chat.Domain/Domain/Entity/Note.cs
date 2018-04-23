using System;
using Chat.Domain.Domain.Enum;

namespace Chat.Domain.Domain.Entity
{
    public class Note
    {
        public User User           { get; set; }
        public String Text         { get; set; }
        public String Preview      { get; set; }
        public DateTime DateTime   { get; set; }
        public ENoteType NoteType  { get; set; }
        public DateTime EventTime  { get; set; }
    }
}
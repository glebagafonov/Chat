using System;
using Chat.Domain.Domain.Enum;

namespace Chat.Domain.Domain.Entity
{
    public class Entity
    {
        public Guid Id            { get; set; }
        public EEntityState State { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
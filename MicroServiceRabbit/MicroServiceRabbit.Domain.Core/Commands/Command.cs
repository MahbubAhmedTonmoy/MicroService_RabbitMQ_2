using System;
using MicroServiceRabbit.Domain.Core.Events;

namespace MicroServiceRabbit.Domain.Core.Commands
{
    public abstract class Command: Message
    {
        public DateTime Timestamp {get; protected set; } // only those inherit set this time

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
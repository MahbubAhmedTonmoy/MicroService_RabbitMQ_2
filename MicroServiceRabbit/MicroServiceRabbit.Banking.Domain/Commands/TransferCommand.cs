using MicroServiceRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Banking.Domain.Commands
{
    public abstract class TransferCommand : Command
    {
        public int Form { get; protected set; }
        public int To { get; protected set; }
        public decimal Ammount { get; protected set; }
    }
}

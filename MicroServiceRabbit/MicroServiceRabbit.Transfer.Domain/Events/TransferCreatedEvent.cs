﻿using MicroServiceRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent: Event
    {
        public int Form { get; protected set; }
        public int To { get; protected set; }
        public decimal Ammount { get; protected set; }


        public TransferCreatedEvent(int form, int to, decimal ammount)
        {
            Form = form;
            To = to;
            Ammount = ammount;
        }
    }
}

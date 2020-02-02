using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand: TransferCommand
    {
        public CreateTransferCommand(int form, int to, decimal ammount)
        {
            Form = form;
            To = to;
            Ammount = ammount;
        }
    }
}

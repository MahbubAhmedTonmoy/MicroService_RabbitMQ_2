using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Banking.Application.DTO
{
    public class TransferAmmount
    {
        public int FromAccount { get; set; }
        public int TOAccount { get; set; }
        public decimal Balence { get; set; }
    }
}

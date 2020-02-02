using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmmount { get; set; }
    }
}

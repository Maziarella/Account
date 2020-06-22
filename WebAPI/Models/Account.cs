using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Account
    {
        public int IdAccount { get; set; }
        public BigInteger AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal AvailableFunds { get; set; }
        public decimal Blance { get; set; }
        public bool IsCard { get; set; }
    }
}

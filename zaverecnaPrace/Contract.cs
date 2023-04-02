using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnaPrace
{
    internal class Contract
    {
        public int ContractNumber { get; set; }
        public string Customer { get; set; }
        public string Description { get; set; }

        public Contract(int contractNumber, string customer, string description)
        {
            ContractNumber = contractNumber;
            Customer = customer;
            Description = description;
        }

        public Contract(int contractNumber)
        {
            ContractNumber = contractNumber;
        }
    }
}

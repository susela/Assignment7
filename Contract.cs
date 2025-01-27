using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCellphonev2025.Model
{
    public class Contract : CellphoneAccount
    {
        //fields
        public string AccountHolderName { get; set; }
        public string Address { get; set; }
        public int ContractLengthMonths { get; set; }

        //parametrized
        public Contract(string cellPhoneNumber, double totalCallTime,
               double totalCost, string accName, string address, int lengthMonths) : base(cellPhoneNumber, totalCallTime, totalCost) //connecting the parent and child class using the keyword base
        {
            this.AccountHolderName = accName;
            this.Address = address;
            this.ContractLengthMonths = lengthMonths;

        }

    }
}

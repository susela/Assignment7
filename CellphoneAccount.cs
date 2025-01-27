using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleAppCellphonev2025.Model
{
    public class CellphoneAccount
    {
        //fields/Properties common to all accounts
        private string _cellPhoneNumber;
        private double _totalCallTime;
        private double _totalCost;

        //Getter and Setters
        public String CellPhoneNumber
        {
            get { return _cellPhoneNumber; }
            set { _cellPhoneNumber = value; }
        }
        private int myVar;

        public double TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }
        public double TotalCallTime
        {
            get { return _totalCallTime; }
            set { _totalCallTime = value; }
        }
        //default constructor
        public CellphoneAccount()
        {

        }
        //1-parametrized constructor
        public CellphoneAccount(string cellPhoneNumber, double totalCallTime, double totalCost)
        {
            this._cellPhoneNumber = cellPhoneNumber;
            this._totalCallTime = totalCallTime;
            this._totalCost = totalCost;
        }

        //2-parametrized constructor
        public CellphoneAccount(string cellPhoneNumber)
        {
            this._cellPhoneNumber = cellPhoneNumber;
        }

        //Override ToString()
        public override string? ToString()
        {
            // return base.ToString();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this._cellPhoneNumber,-16}\t {this._totalCallTime,-15}" +
                $"\t{this._totalCost,-11}");
            stringBuilder.AppendLine("------------------------------------");
            return stringBuilder.ToString();


        }



    }
}
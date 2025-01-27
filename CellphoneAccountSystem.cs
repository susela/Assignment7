using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppCellphonev2025.Model;

namespace ConsoleAppCellphonev2025.DAL
{
    public class CellphoneAccountSystem
    {
        //Storing Data
        public static CellphoneAccount[] cellPhoneaccounts = new CellphoneAccount[50];

        //To keep track of number of accounts added
        private static int counter = 0;

        //Method to Add a new Account
        public static void AddNewAccount(CellphoneAccount account)
        {
            if (counter < cellPhoneaccounts.Length)
            {
                cellPhoneaccounts[counter] = account;
                counter++;
                Console.WriteLine("Added new entry successfully");
            } 
            else
            {
                Console.WriteLine("Cannot add more accounts. List of account is full.");
            }
        }

        //Method to display all accounts
        public static void DisplayAllAccounts()
        {
            //display output
            foreach (var account in cellPhoneaccounts)
            {
                if (account != null)
                {
                    Console.WriteLine(account);
                }

            }
        }
        //Method to search using phone number
        public static void SearchByPhoneNumber(string phoneNumber)
        {
            bool found = false;
            foreach (var account in cellPhoneaccounts)
            {
                if (account != null && account.CellPhoneNumber == phoneNumber)
                {
                    Console.WriteLine("Account found:");
                    Console.WriteLine(account);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("No account found with the given phone number.");
            }
        }
    }
}


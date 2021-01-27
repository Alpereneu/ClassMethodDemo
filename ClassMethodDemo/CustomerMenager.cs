using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerMenager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("New customer added: " + customer.ID + " - " + customer.Name);
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine("The customer removed: " + customer.ID + " - " + customer.Name);
        }

        public void Listing(Customer customer)
        {
            Console.WriteLine("Customer ID: " + customer.ID + 
                "\nCustomer Name: " + customer.Name + 
                "\nCustomer Surname: " + customer.Surname + 
                "\nCustomer Credit Type: " + customer.CreditType + 
                "\nCustomer Interest Rate: " + "%" + customer.InterestRate);
        }
    }
}

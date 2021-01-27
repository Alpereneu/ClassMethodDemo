using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID =1;
            customer1.Name = "John";
            customer1.Surname = "Garcia";
            customer1.CreditType = "Taşıt Kredisi";
            customer1.InterestRate = 12;

            Customer customer2 = new Customer();
            customer2.ID = 2;
            customer2.Name = "Linda";
            customer2.Surname = "Wilson";
            customer2.CreditType = "İhtiyaç Kredisi"; 
            customer2.InterestRate = 23;

            Customer customer3 = new Customer()
            {
                ID = 3,
                Name = "James",
                Surname = "Smith",
                CreditType = "Konut Kredisi",
                InterestRate = 17.5
            };

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerMenager customerMenager = new CustomerMenager();
            customerMenager.Add(customer1);
            customerMenager.Add(customer3);

            customerMenager.Listing(customer2);

            customerMenager.Remove(customer2);
            customerMenager.Remove(customer3);
        }
    }
}
using System;
using EF_Core_Scaffolding.ef_core_examples_database;

namespace EF_Core_Scaffolding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The actual Scallfolding is done in the Package manager Console.

            //The followng command is used for that:
            //Scaffold-DbContext "server=SEVER;user=USER;password=PASSWORD;database=DATABASE" Pomelo.EntityFrameworkCore.MySql -OutputDir ORDNERNAME_IM_PROJEKT -Tables TABLE -f

            //In our Scenario:
            //Scaffold-DbContext "server=localhost;user=root;password=test#1234;database=ef_core_examples" Pomelo.EntityFrameworkCore.MySql -OutputDir ef_core_examples_database -Tables sales -f
            
            //See ef_core_examples_database for the generated files
            //We can access this by adding: using EF_Core_Scaffolding.ef_core_examples_database;

            var Context = new ef_core_examplesContext();
            Context.Sales.Add(new Sale 
            { 
                CostumerName = "Test", 
                OrderNumber = 1, 
                ShippingAdress = "Test", 
                Product = "Macbook Pro M1 2020", 
                Quantity = 1, 
                Value = 999, 
                IsDelivered= false, 
                IsPaymentRecieved=true, 
                IsShiped = true
            });
            Context.SaveChanges();


        }
    }
}
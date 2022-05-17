using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rudgery_S00214383_FinalExam
{
    //main class
    public class RentalProperty
    {
        //properties
        public int ID { get; set; }

        public string RentalType { get; set; }

        public string  Location { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        //method to increase rent by percentage
        public decimal IncreaseRent(decimal price)
        {
            decimal percentage1 = 0.1m;
            decimal percentage2 = 0.2m;
           
           return Price *= price;

        }



        
    }

    //code to create a database
    
    public class RentalData : DbContext
    {
        public RentalData() : base("MyRental0956") { }

        public DbSet<RentalProperty> AllRentals { get; set; }
    }
}

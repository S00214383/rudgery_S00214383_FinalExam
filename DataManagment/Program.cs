using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rudgery_S00214383_FinalExam;

namespace DataManagment
{
     public   class Program
    {
        static void Main(string[] args)
        {
            //creating database
            RentalData db = new RentalData();

            using(db)
            {
                RentalProperty p1 = new RentalProperty()
                {
                    Price = 300,
                    RentalType = "Flat",
                    //TypeOfRental = RentalType.Flat,
                    Description = "A modern 1 bedroom apartment located close to the campus." +
    "  The accomodation comprises of 1 en-suite bedroom with a study area, " +
    "a small kitchen and a lounge/dining room",
                    Location = "Town Centre"
                };

                RentalProperty p2 = new RentalProperty()
                {
                    Price = 350,
                    //TypeOfRental = RentalType.Share,
                    RentalType = "Share",
                    Description = "A modern 4 bedroom townhouse located 2 km from the campus. " +
                    "The house has 4 large double bedrooms with ample space for a desk, " +
                    "a large kitchen with all mod cons.  " +
                    "There is also a dining room and a large sitting room",
                    Location = "Ballinode"
                };

                RentalProperty p3 = new RentalProperty()
                {
                    Price = 400,
                    //TypeOfRental = RentalType.Share,
                    RentalType = "Share",
                    Description = "1 bedroom available to share in a 3 bedroom house located in the " +
                    "beautiful seaside village of Strandhill.  The property is located on the bus route to " +
                    "IT Sligo with regular buses to and from the campus",
                    Location = "Strandhill"
                };

                Console.WriteLine("Properties has been created");

                db.AllRentals.Add(p1);
                db.AllRentals.Add(p2);
                db.AllRentals.Add(p3);

                //adding data do the db
                Console.WriteLine("Data has been added to the database");

                //saving data
                db.SaveChanges();
                Console.WriteLine("Data saved");

                Console.WriteLine("Press any key to close");

                Console.ReadLine();
            }

        }
    }
}

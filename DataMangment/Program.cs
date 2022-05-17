using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rudgery_S00214383_FinalExam;

namespace DataMangment
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating database
            RentalData db2 = new RentalData();

            using (db2)
            {
                RentalProperty p12 = new RentalProperty()
                {
                    Price = 300,
                    RentalType = "Flat",
                    //TypeOfRental = RentalType.Flat,
                    Description = "A modern 1 bedroom apartment located close to the campus." +
    "  The accomodation comprises of 1 en-suite bedroom with a study area, " +
    "a small kitchen and a lounge/dining room",
                    Location = "Town Centre",
                    HouseIcon = "/images/Flat.png"
                };

                RentalProperty p22 = new RentalProperty()
                {
                    Price = 350,
                    //TypeOfRental = RentalType.Share,
                    RentalType = "Share",
                    Description = "A modern 4 bedroom townhouse located 2 km from the campus. " +
                    "The house has 4 large double bedrooms with ample space for a desk, " +
                    "a large kitchen with all mod cons.  " +
                    "There is also a dining room and a large sitting room",
                    Location = "Ballinode",
                    HouseIcon = "/images/share.png"
                };

                RentalProperty p32 = new RentalProperty()
                {
                    Price = 400,
                    //TypeOfRental = RentalType.Share,
                    RentalType = "Share",
                    Description = "1 bedroom available to share in a 3 bedroom house located in the " +
                    "beautiful seaside village of Strandhill.  The property is located on the bus route to " +
                    "IT Sligo with regular buses to and from the campus",
                    Location = "Strandhill",
                    HouseIcon = "/images/share.png"
                };

                Console.WriteLine("Properties has been created");

                db2.AllRentals.Add(p12);
                db2.AllRentals.Add(p22);
                db2.AllRentals.Add(p32);

                //adding data do the db
                Console.WriteLine("Data has been added to the database");

                //saving data
                db2.SaveChanges();
                Console.WriteLine("Data saved" +
                    "");

                Console.WriteLine("Press any key to close");

                Console.ReadLine();
            }
        }
    }
}

// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    // This program is used to showcase the observer design pattern.
    // It is about differently priced product objects inside of different 
    // spacestation objects (subjects), and a spaceship object (observer) 
    // that gets the most recent product prices from a station, as long
    // as it is registered as an observer to it. Otherwise the ship is in
    // outer space.
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating station and ship objects

            // 10 stations
            SpaceStation station1 = new SpaceStation();
            SpaceStation station2 = new SpaceStation();
            SpaceStation station3 = new SpaceStation();
            SpaceStation station4 = new SpaceStation();
            SpaceStation station5 = new SpaceStation();
            SpaceStation station6 = new SpaceStation();
            SpaceStation station7 = new SpaceStation();
            SpaceStation station8 = new SpaceStation();
            SpaceStation station9 = new SpaceStation();
            SpaceStation station10 = new SpaceStation();

            // 5 ships
            SpaceShip ship1 = new SpaceShip();
            SpaceShip ship2 = new SpaceShip();
            SpaceShip ship3 = new SpaceShip();
            SpaceShip ship4 = new SpaceShip();
            SpaceShip ship5 = new SpaceShip();
  
            // Make 10 copies of lists of products, one for each station
            // so that each station has different prices of products
            List<Product> temp1 = new List<Product>();
            List<Product> temp2 = new List<Product>();
            List<Product> temp3 = new List<Product>();
            List<Product> temp4 = new List<Product>();
            List<Product> temp5 = new List<Product>();
            List<Product> temp6 = new List<Product>();
            List<Product> temp7 = new List<Product>();
            List<Product> temp8 = new List<Product>();
            List<Product> temp9 = new List<Product>();
            List<Product> temp10 = new List<Product>();

            // Create 5 products and give each a name and a price
            // then add them to the list temp1.
            // This temp1 list will be used by station 1
            Product prod1 = new Product();
            Product prod2 = new Product();
            Product prod3 = new Product();
            Product prod4 = new Product();
            Product prod5 = new Product();
            temp1.Add(prod1);
            temp1.Add(prod2);
            temp1.Add(prod3);
            temp1.Add(prod4);
            temp1.Add(prod5);
            temp1[0].ProductName = "Product 1";
            temp1[0].ProductPrice = 11;
            temp1[1].ProductName = "Product 2";
            temp1[1].ProductPrice = 12;
            temp1[2].ProductName = "Product 3";
            temp1[2].ProductPrice = 13;
            temp1[3].ProductName = "Product 4";
            temp1[3].ProductPrice = 14;
            temp1[4].ProductName = "Product 5";
            temp1[4].ProductPrice = 15;
            station1.Products = temp1;

            // These new products have different prices than from station1
            // and will be used in station2 by adding them into the temp2 list
            Product prod6 = new Product();
            Product prod7 = new Product();
            Product prod8 = new Product();
            Product prod9 = new Product();
            Product prod10 = new Product();
            temp2.Add(prod6);
            temp2.Add(prod7);
            temp2.Add(prod8);
            temp2.Add(prod9);
            temp2.Add(prod10);
            temp2[0].ProductName = "Product 1";
            temp2[0].ProductPrice = 21;
            temp2[1].ProductName = "Product 2";
            temp2[1].ProductPrice = 22;
            temp2[2].ProductName = "Product 3";
            temp2[2].ProductPrice = 23;
            temp2[3].ProductName = "Product 4";
            temp2[3].ProductPrice = 24;
            temp2[4].ProductName = "Product 5";
            temp2[4].ProductPrice = 25;
            station2.Products = temp2;

            // These new products have different prices and will
            // be used in station3 by adding them into the temp3 list
            Product prod11 = new Product();
            Product prod12 = new Product();
            Product prod13 = new Product();
            Product prod14 = new Product();
            Product prod15 = new Product();
            temp3.Add(prod11);
            temp3.Add(prod12);
            temp3.Add(prod13);
            temp3.Add(prod14);
            temp3.Add(prod15);
            temp3[0].ProductName = "Product 1";
            temp3[0].ProductPrice = 31;
            temp3[1].ProductName = "Product 2";
            temp3[1].ProductPrice = 32;
            temp3[2].ProductName = "Product 3";
            temp3[2].ProductPrice = 33;
            temp3[3].ProductName = "Product 4";
            temp3[3].ProductPrice = 34;
            temp3[4].ProductName = "Product 5";
            temp3[4].ProductPrice = 35;
            station3.Products = temp3;


            /* TESTING */

            // Assigning ship1's location to equal station1's ID to 
            // test if the observer implementation works.
            station1.StationID = 1;
            ship1.Location = 1;
            if (ship1.Location == station1.StationID) // If the ship location matches the station ID
            {
                station1.RegisterObserver(ship1);   // Register ship1 as an observer to station1
                                                    // to automatically update the ship's products
                                                    // from the subject station1.

                Console.WriteLine(ship1.ToString()); // proof that ship1's products are now the list
                                                     // temp1 used by station1.

                station1.RemoveObserver(ship1);     // Removing ship1 as an observer to station1
                                                    // will cause the ship to be in outer space and 
                                                    // the ship's products will turn to null until
                                                    // it registers with another station.
                                                    
                Console.WriteLine(ship1.ToString());    // proof that ship1's products are now null

                // Now testing when ship1's location is equal to station2
                station2.StationID = 2;
                ship1.Location = 2;
                if (ship1.Location == station2.StationID)
                {
                    station2.RegisterObserver(ship1); // Register ship1 as an observer to station2

                    Console.WriteLine(ship1.ToString()); // Proof that ship1's products have updated to
                                                         // the list temp2 used by station2

                    station2.Products = temp3;    // Changing station2's product list to the list temp3
                    Console.WriteLine(ship1.ToString());  // still gets automatically updated in the ship
                                                          // because its still registered as observer


                    station2.Products[0].ProductPrice = 38; // Updating station2's first product in the list
                    Console.WriteLine(ship1.ToString());    // still gets automatically updated in the ship
                }                                           // because its still registered
                Console.ReadLine();
            }
        }
    }
}

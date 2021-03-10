// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    // Space station objects
    public class SpaceStation:ISubject   // implements the ISubject interface
    {                                    // to become a subject for observers
        // Class Variables
        private int stationID;
        private List<Product> products;
        private List<SpaceShip> dockedSpaceShips;   // this list tracks the subject's observers

        // Gets and sets
        public int StationID
        {
            get
            {
                return this.stationID;
            }
            set
            {
                this.stationID = value;
            }
        }
        public List<Product> Products
        {
            get
            {
                return this.products;
            }

            // Every time the products' values change in a station, 
            // a method that updates the observers will be called.
            // This is part of the observer pattern.
            set
            {
                this.products = value;
                PricesChanged();    // method that updates the subject's observers
            }
        }
        public List<SpaceShip> DockedSpaceShips
        {
            get
            {
                return this.dockedSpaceShips;
            }
            set
            {
                this.dockedSpaceShips = value;
            }
        }
        // Constructor makes a new list to track observers
        public SpaceStation()
        {
            this.dockedSpaceShips = new List<SpaceShip>();
        }

        // These class methods are part of the observer pattern.
        // They are implemented from the ISubject interface to add,
        // remove, and update observers from the observers list.
        public void RegisterObserver(SpaceShip o)
        {
            dockedSpaceShips.Add(o);
            o.LocalPrices = products;   // Automatically assign the products at the 
                                        // observer ship to the products at the subject 
        }                               // station during registration.

        public void RemoveObserver(SpaceShip o)
        {
            int i = dockedSpaceShips.IndexOf(o); // get index of ship in the observer list
            if (i >= 0)
            {
                for (int j = 0; j < 5; j++)     // loop all 5 products in the ship's product list
                {                               // change the product price to the default indicating 
                                                // the ship has no subject to observe (deep space).
                    dockedSpaceShips[i].LocalPrices[j].ProductName = "N/A";
                    dockedSpaceShips[i].LocalPrices[j].ProductPrice = 99999.99;
                }
                dockedSpaceShips[i].Location = -1; // ship now in outer space
                dockedSpaceShips.RemoveAt(i);   // ship now no longer an observer 
            }
        }

        // Methods to update ship's products
        public void NotifyObservers()
        {
            foreach (IObserver observer in dockedSpaceShips)
            {
                observer.Update(products);
            }
        }
        public void PricesChanged()
        {
            NotifyObservers();
        }
    }
}

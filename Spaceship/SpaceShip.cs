// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    // Spaceship object that implements the IObserver interface to become
    // an observer to space station subjects
    public class SpaceShip:IObserver
    {
        // Class variables
        private int shipID;
        private int location = -1;  // default deep space location
        private List<Product> localPrices;
        

        // Gets and sets
        public int ShipID
        {
            get
            {
                return this.shipID;
            }
            set
            {
                this.shipID = value;
            }
        }
        public int Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }
        public List<Product> LocalPrices
        {
            get
            {
                return this.localPrices;
            }
            set
            {
                this.localPrices = value;
            }
        }
        
        
        // Class methods
        public override String ToString()   // Returns a printable string showing the ship's
        {                                   // products' names and prices at current location
            return "Current products: \n" + localPrices[0].ProductName + ", " + localPrices[0].ProductPrice
                                       + "\n" + localPrices[1].ProductName + ", " + localPrices[1].ProductPrice
                                       + "\n" + localPrices[2].ProductName + ", " + localPrices[2].ProductPrice
                                       + "\n" + localPrices[3].ProductName + ", " + localPrices[3].ProductPrice
                                       + "\n" + localPrices[4].ProductName + ", " + localPrices[4].ProductPrice
                                       + "\n";
        }

        // Implemented from the IObserver interface.
        // This method updates the observer from the subject
        public void Update(List<Product> prices)
        {
            localPrices = prices;
        }
    }
}

// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    // Product object
    public class Product
    {
        // Class Variables
        private int productID;
        private String productName;
        private double productPrice = 99999.99; // default value 

        // Gets and sets
        public int ProductID
        {
            get
            {
                return this.productID;
            }
            set
            {
                this.productID = value;
            }
        }
        public String ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                this.productName = value;
            }
        }
        public double ProductPrice
        {
            get
            {
                return this.productPrice;
            }
            set
            {
                this.productPrice = value;
            }
        }
    }
}

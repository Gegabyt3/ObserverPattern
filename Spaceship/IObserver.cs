// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    // This interface will be implemented by spaceships to be observers 
    // to the subject spacestation. This is part of the observer pattern implementation
    public interface IObserver
    {
        // Update method that will be used by observers to
        // get newest data from the subject spacstation
        void Update(List<Product> prices);
    }
}

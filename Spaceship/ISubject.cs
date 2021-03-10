// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    // This interface is going to be implemented by the spacestations that are going to be subjects
    // for the spaceships to observe. This is part of the observer pattern implementation.
    public interface ISubject
    {
        // Subject has 3 methods: add, remove, update observers
        void RegisterObserver(SpaceShip o);
        void RemoveObserver(SpaceShip o);
        void NotifyObservers();
    }
}

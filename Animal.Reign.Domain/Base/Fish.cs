using System;
using Animal.Reign.Domain.Contracts;

namespace Animal.Reign {
    public abstract class Fish : Animal, IMarine {
        public void swim () {
            throw new NotImplementedException ();
        }
    }
}
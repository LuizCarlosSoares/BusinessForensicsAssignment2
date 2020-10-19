using System;
using Animal.Reign.Domain.Contracts;

namespace Animal.Reign.Domain {
    public class Dolphin : Mammals, IMarine {
        public override void Breed () {
            throw new NotImplementedException ();
        }

        public void swim () {
            throw new NotImplementedException ();
        }
    }
}
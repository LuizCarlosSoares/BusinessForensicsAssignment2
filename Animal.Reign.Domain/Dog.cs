using System;
using Animal.Reign.Domain.Contracts;

namespace Animal.Reign.Domain {
    public class Dog : Mammals, IPet {
        public override void Breed () {
            throw new NotImplementedException ();
        }
    }
}
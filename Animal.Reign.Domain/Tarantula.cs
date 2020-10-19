using System;
using Animal.Reign.Domain.Contracts;

namespace Animal.Reign.Domain {
    public class Tarantula : Insects, IPet {
        public override void Breed () {
            throw new NotImplementedException ();
        }

        public void Hunt () {
            throw new NotImplementedException ();
        }
    }
}
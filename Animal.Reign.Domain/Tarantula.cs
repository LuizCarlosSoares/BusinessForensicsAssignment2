using System;
using Animal.Reign.Domain.Contracts;

namespace Animal.Reign.Domain {
    public class Tarantula : Insects {
        public override void Breed () {
            throw new NotImplementedException ();
        }

        public override string Feed()
        {
            return "specific way that a tarantula feed";
        }



       
    }
}
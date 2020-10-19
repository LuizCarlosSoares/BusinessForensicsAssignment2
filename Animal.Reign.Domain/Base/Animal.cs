using System;

namespace Animal.Reign {
    public abstract class Animal {
        public string Name { get; set; }

        public abstract void Breed ();

        public bool IsDangerous { get; set; }

    }
}
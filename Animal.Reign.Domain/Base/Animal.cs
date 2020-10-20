using System;

namespace Animal.Reign {
    public abstract class Animal {
        public string Name { get; set; }

        public abstract void Breed ();

        public virtual string Feed() {
                return "Common way of an animal feed";
        }

        public bool IsDangerous { get; set; }

    }
}
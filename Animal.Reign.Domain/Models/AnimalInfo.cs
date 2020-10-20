namespace Animal.Reign.Models
{
    public class AnimalInfo
    {

        private Animal animal {get;set;}
        public AnimalInfo(Animal _animal){
            animal = _animal;
        }
        

        public string Name {get {return animal.Name;}}

        public bool IsDangerous {get { return animal.IsDangerous;}}

        public string Image {get;set;}


    }
}
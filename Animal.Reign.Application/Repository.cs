using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using Animal.Reign.Domain.Contracts;
using Animal.Reign.Models;

namespace Animal.Reign.Application
{
    public class Repository<TAnimalInfo> : IRepository<TAnimalInfo> where TAnimalInfo : AnimalInfo
    {
        private List<TAnimalInfo> context = new List<TAnimalInfo>();

        public Repository()
        {
        }

        public void Delete(TAnimalInfo animalToDelete)
        {
            context.Remove(animalToDelete);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public Animal GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<TAnimalInfo> GetDangerous()
        {
            var oc = new ObservableCollection<TAnimalInfo>();

            context.Where(it=> it.IsDangerous).ToList().ForEach((dangerousAnimal)=>{ 
                oc.Add(dangerousAnimal);
            });
         
            return oc;
        }


        
        public ObservableCollection<TAnimalInfo> GetAll()
        {
            var oc = new ObservableCollection<TAnimalInfo>();

            context.ToList().ForEach((animalInfo)=>{ 
                oc.Add(animalInfo);
            });
         
            return oc;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Insert(TAnimalInfo animal)
        {
            context.Add(animal);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Update(TAnimalInfo animalToUpdate)
        {
            var currentEntity = context.FirstOrDefault(it=>it.Name==animalToUpdate.Name);
            currentEntity = animalToUpdate;
        }
    }
}

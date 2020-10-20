using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using Animal.Reign.Domain.Contracts;

namespace Animal.Reign.Application
{
    public class Repository<TAnimal> : IRepository<TAnimal> where TAnimal : Animal
    {
        private List<TAnimal> context = new List<TAnimal>();

        public Repository()
        {
        }

        public void Delete(TAnimal animalToDelete)
        {
            context.Remove(animalToDelete);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public IEnumerable<TAnimal> Get(Expression<Func<TAnimal, bool>> filter = null, Func<IQueryable<TAnimal>, IOrderedQueryable<TAnimal>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public Animal GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<TAnimal> GetDangerous()
        {
            var oc = new ObservableCollection<TAnimal>();

            context.Where(it=> it.IsDangerous).ToList().ForEach((dangerousAnimal)=>{ 
                oc.Add(dangerousAnimal);
            });
         
            return oc;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Insert(TAnimal animal)
        {
            context.Add(animal);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Update(TAnimal animalToUpdate)
        {
            var currentEntity = context.FirstOrDefault(it=>it.Name==animalToUpdate.Name);
            currentEntity = animalToUpdate;
        }
    }
}

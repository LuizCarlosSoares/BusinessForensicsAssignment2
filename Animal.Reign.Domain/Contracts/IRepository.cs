using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;

namespace Animal.Reign.Domain.Contracts {
    public interface IRepository<TAnimal> where TAnimal : Animal

    {

        void Delete (TAnimal entityToDelete);    

        ObservableCollection<TAnimal> GetDangerous();

        void Insert (TAnimal entity);

        void Update (TAnimal entityToUpdate);

    }
}
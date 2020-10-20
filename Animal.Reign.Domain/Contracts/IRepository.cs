using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using Animal.Reign.Models;

namespace Animal.Reign.Domain.Contracts {
    public interface IRepository<TAnimalInfo> where TAnimalInfo : AnimalInfo

    {

        void Delete (TAnimalInfo entityToDelete);    

        ObservableCollection<TAnimalInfo> GetDangerous();

          ObservableCollection<TAnimalInfo> GetAll();

        void Insert (TAnimalInfo entity);

        void Update (TAnimalInfo entityToUpdate);

    }
}
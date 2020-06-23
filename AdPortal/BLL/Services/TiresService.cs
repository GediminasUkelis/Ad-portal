using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class TiresService : IGenericService<Tire>
    {
        private IGenericRepository<Tire> TireRepository;

        public TiresService(IGenericRepository<Tire> TireRepository)
        {
            this.TireRepository = TireRepository;
        }

        public void Delete(int id)
        {
            var dbEntry = TireRepository.GetById(id);
            TireRepository.Delete(dbEntry);
        }

        public List<Tire> GetAll()
        {
           
            return TireRepository.GetAll();
        }

        public Tire GetById(int id)
        {
            return TireRepository.GetById(id);
        }

        public void Insert(Tire obj)
        {
            TireRepository.Insert(obj);
        }

        public void Update(Tire obj)
        {
            TireRepository.Update(obj);
        }

    }
}

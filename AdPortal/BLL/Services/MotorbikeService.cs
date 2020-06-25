using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Services
{
    public class MotorbikeService : IGenericService<Motorbike>
    {
        private IGenericRepository<Motorbike> MotorbikeRepository;

        public MotorbikeService(IGenericRepository<Motorbike> MotorbikeRepository)
        {
            this.MotorbikeRepository = MotorbikeRepository;
        }
       
        public void Delete(Guid id)
        {

            var dbEntry = MotorbikeRepository.GetById(id);
            MotorbikeRepository.Delete(dbEntry);
        }

        public List<Motorbike> GetAll()
        {
           
            return MotorbikeRepository.GetAll();
        }

        public Motorbike GetById(Guid id)
        {
            return MotorbikeRepository.GetById(id);
        }

        public void Insert(Motorbike obj)
        {
            MotorbikeRepository.Insert(obj);
        }

        public void Update(Motorbike obj)
        {
            MotorbikeRepository.Update(obj);
        }

    }
}

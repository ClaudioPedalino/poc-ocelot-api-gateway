using electronic_api.Entities;
using electronic_api.Interfaces;
using electronic_api.Models;
using shared;
using shared.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace electronic_api.Services
{
    public class PhoneService : IPhoneService
    {
        private readonly DataContext _context;

        public PhoneService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<PhoneQueryResult> GetAll()
        {
            var result = _context.Phones.ToList();

            return result.Select(item => new PhoneQueryResult()
            {
                Id = item.Id,
                CreateAt = item.CreateAt,
                Model = item.Model,
                Brand = item.Brand,
                Price = item.Price,
            });
        }

        public Result Create(PhoneCommand request)
        {
            var entity = new Phone();
            entity.Brand = request.Brand;
            entity.Model = request.Model;
            entity.Price = request.Price;
            entity.CreateAt = DateTime.UtcNow.AddHours(-3);
            entity.CreateBy = "pepe";
            entity.DeleteAt = default;
            entity.DeleteBy = default;
            entity.IsDelete = false;

            _context.Phones.Add(entity);
            _context.SaveChanges();
            return Result.Succes($"{nameof(Phone)} created with id: {entity.Id}");
        }
    }
}
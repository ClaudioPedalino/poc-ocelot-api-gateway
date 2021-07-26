using fashion_api.Entities;
using fashion_api.Interfaces;
using fashion_api.Models;
using shared;
using shared.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace fashion_api.Serivce
{
    public class FashionServices : IFashionServices
    {
        private readonly DataContext _context;

        public FashionServices(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<FashionQueryResult> GetAll()
        {
            var result = _context.Fashions.ToList();

            return result.Select(item => new FashionQueryResult()
            {
                Id = item.Id,
                CreateAt = item.CreateAt,
                Description = item.Description,
                Brand = item.Brand,
                Size = item.Size,
                Price = item.Price,
            });
        }

        public Result Create(FashionCommand request)
        {
            var entity = new Fashion();
            entity.Description = request.Description;
            entity.Brand = request.Brand;
            entity.Size = request.Size;
            entity.Price = request.Price;
            entity.CreateAt = DateTime.UtcNow.AddHours(-3);
            entity.CreateBy = "pepe";
            entity.DeleteAt = default;
            entity.DeleteBy = default;
            entity.IsDelete = false;

            _context.Fashions.Add(entity);
            _context.SaveChanges();
            return Result.Succes($"{nameof(Fashion)} created with id: {entity.Id}");
        }
    }
}
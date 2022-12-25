using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Service
{
    public class GioHangService : IGioHangService
    {
        private readonly IRepository<GioHang> _repository;
        /*public GioHangService(IRepository<GioHang> repository)
        {
            _repository = repository;
        }*/
        private readonly DataDbContext _context;
        public readonly DbSet<GioHang> _entities;
         public GioHangService(DataDbContext context)
        {
            _context = context;
            _entities = context.Set<GioHang>();
        }
        public void DeleteGioHang(int id)
        {
            GioHang gioHang = GetGioHang(id);
            _repository.Delete(gioHang);
        }

        public IEnumerable<GioHang> GetAll()
        {
            return _repository.GetAll();
        }

        public GioHang GetGioHang(int id)
        {
            return _entities.SingleOrDefault(e => e.Id == id);
        }

        public void InsertContact(GioHang gioHang)
        {
            _repository.Insert(gioHang);
        }
    }
}

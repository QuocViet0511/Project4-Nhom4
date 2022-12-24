using DomainLayer.Models;
using RepositoryLayer;
using System.Collections.Generic;

namespace ServiceLayer.Service
{
    public class GioHangService : IGioHangService
    {
        private readonly IRepository<GioHang> _repository;
        public GioHangService(IRepository<GioHang> repository)
        {
            _repository = repository;
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
            return _repository.Get(id);
        }

        public void InsertContact(GioHang gioHang)
        {
            _repository.Insert(gioHang);
        }
    }
}

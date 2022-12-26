using DomainLayer.Models;
using System.Collections.Generic;

namespace ServiceLayer.Service
{
    public interface IGioHangService
    {
        IEnumerable<GioHang> GetAll();
        GioHang GetGioHang(int id);
        void InsertContact(GioHang gioHang);
        void DeleteGioHang(int id);
        void UpdateCountry(GioHang gioHang);
    }
}

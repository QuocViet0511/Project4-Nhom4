using DomainLayer.Models;
using System.Collections.Generic;

namespace ServiceLayer.Service
{
    public interface IGioHangService
    {
        IEnumerable<GioHang> GetAll();
        GioHang GetGioHang(int id);
        void InsertGioHang(GioHang gioHang);
        void DeleteGioHang(int id);
        void UpdateGioHang(GioHang gioHang);
    }
}

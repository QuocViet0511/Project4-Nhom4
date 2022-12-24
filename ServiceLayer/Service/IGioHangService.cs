using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public interface IGioHangService
    {
        IEnumerable<GioHang> GetAll();
        GioHang GetGioHang(int id);
        void InsertContact(GioHang gioHang);
        void DeleteGioHang(int id);
    }
}

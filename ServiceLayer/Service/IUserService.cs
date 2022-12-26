using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace ServiceLayer.Service
{
    internal interface IUserService
    {
        IEnumerable<User> GetAll();
        GioHang GetUser(int id);
        void InsertUser(User user);
        void DeleteUser(int id);
        void UpdateUser(User user);
    }
}

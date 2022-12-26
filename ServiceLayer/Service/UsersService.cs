using DomainLayer.Models;
using RepositoryLayer;
using System.Collections.Generic;

namespace ServiceLayer.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetUser(int id);
        void InsertUser(User user);
        void DeleteUser(int id);
        void UpdateUser(User user);
    }
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public void DeleteUser(int id)
        {
            User user = GetUser(id);
            _repository.Delete(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User GetUser(int id)
        {
            return _repository.Get(id);
        }

        public void InsertUser(User user)
        {
            _repository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            _repository.Update(user);
        }
    }
}

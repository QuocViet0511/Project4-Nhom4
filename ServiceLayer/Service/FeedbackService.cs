using DomainLayer.Models;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public interface IFeedbackService
    {
        IEnumerable<Feedback> GetAll();
        Feedback GetFeedback(int id);
        void InsertFeedback(Feedback feedback);
        void DeleteFeedback(int id);
        void UpdateFeedback(Feedback feedback);
    }
    public class FeedbackService : IFeedbackService
    {
        private readonly IRepository<Feedback> _repository;
        public FeedbackService(IRepository<Feedback> repository)
        {
            _repository = repository;
        }

        public void DeleteFeedback(int id)
        {
            Feedback feedback = GetFeedback(id);
            _repository.Delete(feedback);
        }

        public IEnumerable<Feedback> GetAll()
        {
            return _repository.GetAll();
        }

        public Feedback GetFeedback(int id)
        {
            return _repository.Get(id);
        }

        public void InsertFeedback(Feedback Feedback)
        {
            _repository.Insert(Feedback);
        }

        public void UpdateFeedback(Feedback Feedback)
        {
            _repository.Update(Feedback);
        }
    }
}

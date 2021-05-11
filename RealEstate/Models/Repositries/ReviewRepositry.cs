using RealEstate.Data;
using RealEstate.Models;
using RealEstate.Models.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models.Repositries
{
    public class ReviewRepositry : IRepository<Review>
    {
        private readonly ApplicationDbContext context;

        public ReviewRepositry(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Add(Review entity)
        {
            context.Review.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteReview = FindAsync(id);
            context.Review.Remove(deleteReview);
            context.SaveChanges();
        }

        public Review FindAsync(int id)
        {
            return context.Review.Find(id);
        }

        public Review FindAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public IList<Review> ListAsync()
        {
            return context.Review.ToList();
        }

        public List<Review> Search(string term)
        {
            throw new NotImplementedException();
        }

        public List<Review> Search(Property term)
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id, Review entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }

      

        Task IRepository<Review>.Add(Review entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Review>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<IList<Review>> IRepository<Review>.ListAsync()
        {
            throw new NotImplementedException();
        }

        List<Property> IRepository<Review>.Search(Property term)
        {
            throw new NotImplementedException();
        }
    }
}

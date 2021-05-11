using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealEstate.Models;



namespace RealEstate.Models.Repositries
{
    public class ImageRepositry : IRepository<Image>, IDisposable
    {
        private readonly ApplicationDbContext context;

        public ImageRepositry(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task Add(Image entity)
        {
            context.Image.Add(entity);
            await context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteImageAsync(int id)
        {
            var deleteReview = await FindAsync(id);
            context.Image.Remove(deleteReview);
            context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<Image> FindAsync(int? id)
        {

            if (id == null)
            {
                return null;
            }

            return await context.Image.FindAsync(id);
        }

        public async Task<IList<Image>> ListAsync()
        {
            return (IList<Image>)await context.Image.ToListAsync();
        }

        public List<Image> Search(Property term)
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id, Image entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }



        Task IRepository<Image>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Image IRepository<Image>.FindAsync(int? id)
        {
            throw new NotImplementedException();
        }

        List<Property> IRepository<Image>.Search(Property term)
        {
            throw new NotImplementedException();
        }
    }
}

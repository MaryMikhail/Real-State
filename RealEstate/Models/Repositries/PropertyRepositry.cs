using RealEstate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models.Repositries
{
    public class PropertyRepositry : IRepository<Property>
    {
        private readonly ApplicationDbContext context;

        public PropertyRepositry(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Add(Property entity)
        {
            context.Property.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteProp = FindAsync(id);
            context.Property.Remove(deleteProp);
            context.SaveChanges();
        }

        public Property FindAsync(int id)
        {
            return context.Property.Find(id);
        }

        public Property FindAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public IList<Property> ListAsync()
        {
            return context.Property.ToList();
        }

        public List<Property> Search(Property propertySearch)
        {
            if (propertySearch != null)
            {
                var result = context.Property.ToList();
                if (propertySearch.PropertyStatus.HasValue)
                    result = result.Where(x => x.PropertyStatus == propertySearch.PropertyStatus).ToList();
                if (propertySearch.PropertyType.HasValue)
                    result = result.Where(x => x.PropertyType == propertySearch.PropertyType).ToList();
                if (propertySearch.Country.HasValue)
                    result = result.Where(x => x.Country == propertySearch.Country).ToList();
                if (propertySearch.Price.HasValue)
                    result = result.Where(x => x.Price <= propertySearch.Price).ToList();
                if (propertySearch.Rooms.HasValue)
                    result = result.Where(x => x.Rooms == propertySearch.Rooms).ToList();
                if (propertySearch.Bathrooms.HasValue)
                    result = result.Where(x => x.Bathrooms == propertySearch.Bathrooms).ToList();
                if (propertySearch.YearBuilt.Year >= 2014)
                    result = result.Where(x => x.YearBuilt.Year == propertySearch.YearBuilt.Year).ToList();
                return result.ToList();
            }
            throw new NullReferenceException();
        }

        public void Update(int id, Property entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }

        Task IRepository<Property>.Add(Property entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Property>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<IList<Property>> IRepository<Property>.ListAsync()
        {
            throw new NotImplementedException();
        }

        Task IRepository<Property>.Update(int id, Property entity)
        {
            throw new NotImplementedException();
        }
    }
}

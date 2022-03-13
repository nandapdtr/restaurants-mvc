using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        public void Add(Restaurant restaurant)
        {
            //This step prepares the data to be added to the table
            db.Restaurants.Add(restaurant);
            //This step will add the data into the table
            db.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return db.Restaurants;
        }

        public void Update(Restaurant restaurant)
        {
            //This approach we should not do because if the different users updating the same record then the last user update will be taken
            //var r = Get(restaurant.Id);
            //r.Name = restaurant.Name;
            //db.SaveChanges();
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}

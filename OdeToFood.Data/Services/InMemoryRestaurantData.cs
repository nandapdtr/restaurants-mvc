using System;
using System.Collections.Generic;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Bawurchi", Cuisine = CuisineType.Indian},
                new Restaurant{Id = 2, Name = "Pizzahut", Cuisine = CuisineType.Italian},
                new Restaurant{Id = 3, Name = "Talpakatti Biryani", Cuisine = CuisineType.French},
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.Find(x => x.Id == id);
        }
    }
}

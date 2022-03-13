using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public class OdeToFoodDbContext: DbContext
    {
        //This creates a table called Restaurants in the database and creates the columns based on the model Restaurant
        //If the model contains Id property then entity framework makes it as a primary key and treat it as an identifier
        //The database choosen by entity framework will be based on the connection string in the App.config file
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

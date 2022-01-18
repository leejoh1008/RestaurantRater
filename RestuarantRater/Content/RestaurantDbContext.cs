using RestuarantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestuarantRater.Content
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("Default Connection")
        {

        }


        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
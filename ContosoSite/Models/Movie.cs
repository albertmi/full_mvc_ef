using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContosoSite.Models
{
    public class Movie
    {

        public int ID { get; set; }
        public string Title{ get; set; }
        public DateTime DateRelease { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class movieDbContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
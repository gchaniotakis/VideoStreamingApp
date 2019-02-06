namespace VideoStreamingApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MovieDb : DbContext
    {

        public MovieDb()
            : base("name=MovieDb")
        {
        }



        public virtual DbSet<Movie> Movies { get; set; }

       
    }


}
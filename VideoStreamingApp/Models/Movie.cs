using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoStreamingApp.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; } 
        public int Duration { get; set; }
        public string Trailer_Url { get; set; }
        public string Thumbnail { get; set;  }
    }

    public enum Genre
    {
        Action, 
        Horror,
        ScienceFiction,
        Comedy
    }
}
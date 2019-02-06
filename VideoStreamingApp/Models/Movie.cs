using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoStreamingApp.Models
{
    public class Movie
    {
        public int id { get; set; }
        [Required (ErrorMessage ="You have to input a title!!!")]
        public string Title { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "You have to input a duration!!!")]
        public int Duration { get; set; }
        [Display(Name ="Trailer URL")]
        [Required(ErrorMessage = "You have to input a trailer url!!!")]
        public string Trailer_Url { get; set; }
        [Display(Name ="Thumbnail URL")]
        [Required(ErrorMessage = "You have to input a thumbnail url!!!")]
        public string Thumbnail_Url { get; set;  }
    }

    public enum Genre
    {
        Action, 
        Horror,
        [Display(Name ="Science Fiction")]
        ScienceFiction,
        Comedy,
        Drama
    }
}
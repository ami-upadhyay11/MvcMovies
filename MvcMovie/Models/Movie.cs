using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    // Developer branch
    //pull
    //feach
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage ="Please enter Title of movie !!!") ]
        public string Title { get; set; }
        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat (DataFormatString="{0:yyy-MM-dd}",ApplyFormatInEditMode=true )]
        public DateTime  ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required(ErrorMessage ="Please Enter Genre of the movie !!!")]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }

  public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("name=MovieDBContext")
        { }

        public virtual DbSet<Movie> Movies { get; set; }

    }
}

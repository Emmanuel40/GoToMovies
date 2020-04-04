﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoToMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }

        [Display(Name="Genre")]
        [Required]
        public byte GenreId { get; set; }

        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }


        [Display(Name = "Number In Stock")]
        [Range (1,20)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MediaDB
{
    class Movie
    {
        [Required]
        public string title { get; set; }
        [RangeAttribute(0, 3000)]
        public int year { get; set; }
        [Required, RegularExpression("/^[A-Za-z]+$/")]
        public string director { get; set; }
        [Required, RegularExpression("/^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$/")]
        public TimeSpan length { get; set; }
        [RangeAttribute(0, 100)]
        public int tomato_rating { get; set; }
        public int seen { get; set; }
        [Required, RegularExpression("/^[A-Za-z]+$/")]
        public string genre { get; set; }

        public Movie(string in_title, int in_year, string in_director, 
            string in_length, int in_tomato, int in_seen, string in_genre)
        {
            title = in_title;
            year = in_year;
            director = in_director;
            length = TimeSpan.Parse(in_length);
            tomato_rating = in_tomato;
            seen = in_seen;
            genre = in_genre;
        }

    }
}

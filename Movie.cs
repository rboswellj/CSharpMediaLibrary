using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MediaDB
{
    public class Movie
    {
        [Required]
        public string Title { get; set; }
        [RangeAttribute(0, 3000)]
        public int Year { get; set; }
        [Required, RegularExpression("/^[A-Za-z]+$/")]
        public string Director { get; set; }
        [Required, RegularExpression("/^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$/")]
        public TimeSpan Length { get; set; }
        [RangeAttribute(0, 100)]
        public int Rating { get; set; }
        public int Seen { get; set; }
        [Required, RegularExpression("/^[A-Za-z]+$/")]
        public string Genre { get; set; }

        public Movie(string inTitle, int inYear, string inDirector, 
            string inLength, int inRating, int inSeen, string inGenre)
        {
            Title = inTitle;
            Year = inYear;
            Director = inDirector;
            Length = TimeSpan.Parse(inLength);
            Rating = inRating;
            Seen = inSeen;
            Genre = inGenre;
        }

    }
}

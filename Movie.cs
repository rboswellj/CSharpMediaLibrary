using System;
using System.Collections.Generic;
using System.Text;

namespace MediaDB
{
    class Movie
    {
        string title { get; set; }
        int year { get; set; }
        string director { get; set; }
        string length { get; set; }
        int tomato_rating { get; set; }
        int seen { get; set; }
        string genre { get; set; }

        public Movie(string in_title, int in_year, string in_director, 
            string in_length, int in_tomato, int in_seen, string in_genre)
        {
            title = in_title;
            year = in_year;
            director = in_director;
            length = in_length;
            tomato_rating = in_tomato;
            seen = in_seen;
            genre = in_genre;
        }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace MediaDB
{
    public class Game
    {
        public Game(string inTitle, int inYear, string inDeveloper,
            string inPlatform, int inScore, int inPlayed, string inGenre)
        {
            Title = inTitle;
            Year = inYear;
            Developer = inDeveloper;
            Platform = inPlatform; 
            Score = inScore;
            Played = inPlayed;
            Genre = inGenre;
        }

        [Required] public string Title { get; set; }

        [RangeAttribute(0, 3000)] public int Year { get; set; }

        [Required]
        [RegularExpression("/^[A-Za-z]+$/")]
        public string Developer { get; set; }

        [Required] public string Platform { get; set; }

        [RangeAttribute(0, 100)] public int Score { get; set; }

        public int Played { get; set; }

        [Required]
        [RegularExpression("/^[A-Za-z]+$/")]
        public string Genre { get; set; }
    }
}
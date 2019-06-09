using CoderGirl_MVCMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderGirl_MVCMovies.Data
{
    public class MovieRatingRepository : IMovieRatingRepository
    {
        public static List<Movie> Movies = new List<Movie>();

        public double GetAverageRatingByMovieName(string movieName)
        {
            return Movies.Where(mo => mo.Name == movieName).Average(mo => mo.Rating);
        }

        public List<int> GetIds()
        {
            List<int> id = Movies.Select(mo => mo.Id).ToList();

            return id;
        }

        public string GetMovieNameById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetRatingById(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveRating(string movieName, int rating)
        {
            throw new NotImplementedException();
        }
    }
}

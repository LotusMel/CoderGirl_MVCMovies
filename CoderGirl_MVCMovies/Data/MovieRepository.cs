using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderGirl_MVCMovies.Data
{
    public class MovieRepository : IMovieRepository
    {
        static List<Movie> movies = new List<Movie>();
        static int nextId = 1;

        public List<Movie> GetMovies()
        {
            return movies;
        }


    }
}

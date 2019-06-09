using CoderGirl_MVCMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoderGirl_MVCMovies.Data;
using Microsoft.AspNetCore.Mvc;
using CoderGirl_MVCMovies.Controllers;


namespace CoderGirl_MVCMovies.Data
{
   
    public class MovieRepository : IMovieRepository
    {
        static List<Movie> movies = new List<Movie>();
        static int nextId = 1;

        public Movie getById(int Id)
        {
            List<int> id = movies.Select(m => m.Id).ToList();
            return id;
        }

        public List<MovieRepository> GetMovies()
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }
    }
}

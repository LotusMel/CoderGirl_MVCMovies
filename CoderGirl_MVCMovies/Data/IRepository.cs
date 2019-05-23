using CoderGirl_MVCMovies.Models;
using CoderGirl_MVCMovies.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderGirl_MVCMovies.Data
{
    public interface IRepository 
    {
        IModel GetModel(int id);
        List<IModel> GetModels();
        int Save(IModel model);
        void Delete(int id);
        void Update(IModel model);
    }
}

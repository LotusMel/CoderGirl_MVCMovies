using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderGirl_MVCMovies.Data
{
    public class BaseRepository
    {
        protected List<IModel> models = new List<IModel>;
        protected static int nextId = 1;

        public void Delete(int id)
        {
            models.RemoveAll(d => d.Id == id);
        }

        public virtual IModel GetById(int Id)
        {
            return models.SingleOrDefault(m => m.Id == id);
        }
    }
}

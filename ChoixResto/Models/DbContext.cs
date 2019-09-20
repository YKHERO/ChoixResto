using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public class DbContext
    {
        public DbSet<Sondage> Sondages { get; set; }
        public DbSet<Resto> Restos { get; set; }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
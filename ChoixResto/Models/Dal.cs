using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
  public class Dal : IDal
{
    private DbContext bdd;

    public Dal()
    {
        bdd = new DbContext();
    }

    public List<Resto> ObtientTousLesRestaurants()
    {
        return bdd.Restos.ToList();
    }

    public void Dispose()
    {
        bdd.Dispose();
    }
}
}
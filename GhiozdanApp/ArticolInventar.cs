using GhiozdanApp.Inventar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhiozdanApp
{
    public class ArticolInventar : IArticle
    {
        public double weight { get; set; }
        public double volume { get; set; }

        public ArticolInventar(double _weight, double _volume)
        {
            _weight = weight;
            _volume = volume;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhiozdanApp
{
    public interface IArticle
    {
        public double weight { get; set; }
        public double volume { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GhiozdanApp
{
    public class Ghiozdan
    {
        public int totalArticles = 0;
        public const int weight = 10;
        public const int volume = 10;

        public int size = 10;

        double[,] articleMatrix = new double[weight, volume];

        public bool Adauga(ArticolInventar articol)
        {
            double w = Convert.ToDouble(weight);
            double v = Convert.ToDouble(volume);
            while (w > 0.0 && v > 0.0)
            {
                w -= articol.weight;
                v -= articol.volume;
                totalArticles++;
                return true;
            }

            return false;
        }
    }
}

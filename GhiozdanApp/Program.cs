using System;
using GhiozdanApp;
using GhiozdanApp.Inventar;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ghiozdan ghiozdan = new Ghiozdan();
            Console.WriteLine("Bun venit, meniul de astazi consta in Apa, Arc, Franghie, Portie de mancare, Sabie sau Sageata");
            Console.WriteLine("Ce obiecte doriti sa adaugati in ghiozadan?");

            ArticolInventar art = new ArticolInventar(ghiozdan.size, ghiozdan.size);
            string opt = Console.ReadLine();
            while (opt != null && ghiozdan.Adauga(art) == true)
            {
                switch (opt)
                {
                    case "apa":
                        art = new Apa();
                        ghiozdan.Adauga(art);
                        break;
                    case "arc":
                        art = new Arc();
                        ghiozdan.Adauga(art);
                        break;
                    case "franghie":
                        art = new Franghie();
                        ghiozdan.Adauga(art);
                        break;
                    case "portie de mancare":
                        art = new PortieDeMancare();
                        ghiozdan.Adauga(art);
                        break;
                    case "sabie":
                        art = new Sabie();
                        ghiozdan.Adauga(art);
                        break;
                    case "sageata":
                        art = new Sageata();
                        ghiozdan.Adauga(art);
                        break;
                    default: 
                        Console.WriteLine("input gresit");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("Vrei sa mai adaugi?(d/n):");
                Console.ReadLine();
            }
        }
    }
}
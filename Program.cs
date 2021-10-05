using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Listes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chaine = new List<string>();
            chaine.Add("métro");
            chaine.Add("boulot");
            chaine.Add("dodo");

            foreach (string chainon in chaine)
            {
                Console.WriteLine(chainon);
            }
            Console.WriteLine("-----------------------------");

            chaine.RemoveAt(0);
            chaine.Remove("dodo");
            

            foreach (string chainon in chaine)
            {
                Console.WriteLine(chainon);
                Console.WriteLine("-----------------------------");

            }

            chaine[0] = "repos";

            foreach (string chainon in chaine)
            {
                Console.WriteLine(chainon);
                Console.WriteLine("-----------------------------");

            }

            Console.ReadLine();



        }
    }
}

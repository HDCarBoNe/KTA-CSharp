using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtaPulte.Class;


namespace KtaPulte
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatoire = new Random();
            int nbal = aleatoire.Next(1, 41);
            ListeObjets<string, int>[] tableau = new ListeObjets<string, int>[5];
            int[] tab = new int[5];
            for (int h = 0; h < 5; h++)
            {
                tab[h] = nbal++;
            }
            string[] tab2 = { "Rocher", "Parpin", "Rocher de feu", "Rocher de glace", "Tacos" };
            int[] tab3 = { tab[0], tab[1], tab[2], tab[3], tab[4] };
            for (int i = 0; i < 5; i++)
            {
                tableau[i] = new ListeObjets<string, int>(tab2[i], tab3[i]);
                Console.WriteLine(tableau[i].ToString());
            }
            Console.ReadKey();
        }
    }
}

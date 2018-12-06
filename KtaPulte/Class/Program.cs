using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ProjetCatapulte
{
    class program
    {
        static void Main(string[] args)
        {
            ListeObjets<string, int>[] tableau = new ListeObjets<string, int>[5];
            string[] tab2 = { "Rocher", "Parpin", "Rocher de feu", "Rocher de glace", "Tacos" };
            int[] tab3 = { 0, 16, 19, 40, 25 };
            for (int i = 0; i < 5; i++)
            {
                tableau[i] = new ListeObjets<string, int>(tab2[i], tab3[i]);
                Console.WriteLine(tableau[i].ToString());
            }
            {
                CorpsCatapulte KTA = new CorpsCatapulte();
                KTA.ObjetAEnvoyer();
                KTA.PreparationDuTir();
                KTA.TendreLaCorde();
                KTA.Fire();
                Console.ReadKey();
            }
        }
    }
}

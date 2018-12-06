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
            ListeObjets<string, int>[] tableau = new ListeObjets<string, int>[5];
            string[] tab2 = { "Rocher", "Parpin", "Rocher de feu", "Rocher de glace", "Tacos" };
            int[] tab3 = { 0, 16, 19, 40, 25 };
            for (int i = 0; i < 5; i++)
            {
                tableau[i] = new ListeObjets<string, int>(tab2[i], tab3[i]);
                Console.WriteLine(tableau[i].ToString());
            }
            Catapulte KTA = new Catapulte();
            KTA.Assemblage();
            KTA.Tirer(45);
            string pierre = "Une pierre de 5 Kg";
            KTA.Tirer(pierre);
            KTA.Degats(40);
            Console.ReadKey();
        }
    }
}

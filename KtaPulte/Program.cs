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
            Catapulte KTA = new Catapulte();
            KTA.Assemblage();
            KTA.Tirer(45);
            string pierre = "Une pierre de 5 Kg";
            KTA.Tirer(pierre);
            KTA.getLifeSpoon();
            KTA.getLifeSpoon();
            KTA.setDamageBody(6);
            Console.ReadKey();
        }
    }
}

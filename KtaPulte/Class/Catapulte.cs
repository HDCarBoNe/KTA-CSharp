using System;
namespace KtaPulte.Class
{
    class Catapulte
    {

        public Catapulte(){
            CorpsCatapulte c = new CorpsCatapulte();
        }
        public void Tir()
        {
            Console.WriteLine("Mettre le feu au poudre");
        }
        public void PrepaTir()
        {
            Console.WriteLine("Charger le boulet");
        }
        public void Fire()
        {
            Console.WriteLine("Appel de la fonction mère");
            //base.Fire();
            Console.WriteLine("Feu de tout bois.");
        }

    }
}

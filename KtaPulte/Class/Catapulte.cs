using System;
namespace KtaPulte.Class
{
    class Catapulte : ArmeDeJet
    {
        //Innitialisation de la catapulte et de touts ses modules
        public void Assemblage()
        {
            //setLifeBody();
            setLifeSpoon();
            setLifeRope();
            setLifeBeam();
        }

        public override void Tir()
        {
            Console.WriteLine("Mettre le feu au poudre");
        }
        public override void PrepaTir()
        {
            Console.WriteLine("Charger le boulet");
        }
        public new void Fire()
        {
            Console.WriteLine("Appel de la fonction mère");
            base.Fire();
            Console.WriteLine("Feu de tout bois.");
        }

    }
}

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

        public void Degats(int dgt)
        {
            int LifeBeam = this.getLifeBeam();
            int LifeSpoon = this.getLifeSpoon();
            int LifeRope = this.getLifeRope();
            int LifeKTA = LifeBeam + LifeSpoon + LifeRope;
            int PurcentBeam = LifeBeam / LifeKTA * 100;
            int PurcentRope = LifeRope / LifeKTA * 100;
            int PurcentSpoon = LifeSpoon / LifeKTA * 100;
            Console.WriteLine(PurcentRope);
            setDamageBeam(dgt*PurcentBeam);
            setDamageRope(dgt*PurcentRope);
            setDamageSpoon(dgt*PurcentSpoon);
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

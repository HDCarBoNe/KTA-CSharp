using System;
using System.Net;
using System.IO;
namespace KtaPulte.Class
{
    public class CorpsCatapulte
    {
        protected Rope r;
        protected Beam b;
        protected Spoon s;
        protected Arm a;

        public CorpsCatapulte()
        {
            r = new Rope();
            b = new Beam();
            s = new Spoon();
            a = new Arm();
        }

        public void Assemblage()
        {
            b.setLifeBeam();
            r.setLifeRope();
        }

        public void Degats(int dgt)
        {
            int LifeBeam = b.getLifeBeam();
            int LifeSpoon = s.getLifeSpoon();
            int LifeRope = r.getLifeRope();
            int LifeKTA = LifeBeam + LifeSpoon + LifeRope;
            int PurcentBeam = LifeBeam / LifeKTA * 100;
            int PurcentRope = LifeRope / LifeKTA * 100;
            int PurcentSpoon = LifeSpoon / LifeKTA * 100;
            Console.WriteLine(PurcentRope);
            b.setDamageBeam(dgt * PurcentBeam);
            r.setDamageRope(dgt * PurcentRope);
            s.setDamageSpoon(dgt * PurcentSpoon);
        }
    }
}

using System;
namespace KtaPulte.Class
{
    class Catapulte : ArmeDeJet
    {
        CorpsCatapulte corps;
        public Catapulte()
        {
            corps = new CorpsCatapulte();
        }

        public int CatapulteLife()
        {
            return corps.getLife("Rope");
        }
    }
}

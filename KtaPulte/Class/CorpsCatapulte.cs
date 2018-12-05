using System;
using System.Net;
using System.IO;
namespace KtaPulte.Class
{
    public class CorpsCatapulte : Spoon
    {
        private int lifeBody;

        public void getLifeBody()
        {
            Console.WriteLine(lifeBody);
        }

        public int setDamageBody(int damage)
        {
            lifeBody -= damage;
            Console.WriteLine("Il reste " + lifeBody + " de vie au corps de la catapulte");
            return lifeBody;
        }
    }
}

using System;
namespace KtaPulte.Class
{
    public class ArmeDeJet: CorpsCatapulte
    {
        public void Tirer(int num)
        {
            Console.WriteLine("Tirer avec une puissance de " + num);
        }
        public void Tirer(string num)
        {
            Console.WriteLine("Tirer avec une puissance de " + num);
        }


        public virtual void PrepaTir()
        {
            Console.WriteLine("Tendre les cordages");
        }
        public void Fire()
        {
            Console.WriteLine("Tirer oui, mais avec quoi?");
        }
    }
}

using System;
namespace KtaPulte.Class
{
    public abstract class ArmeDeJet: CorpsCatapulte
    {
        public void Tirer(int num)
        {
            Console.WriteLine("Tirer avec une puissance de " + num);
        }
        public void Tirer(string num)
        {
            Console.WriteLine("Tirer avec une puissance de " + num);
        }
        public int Life { get; set; }
        public abstract void Tir();

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

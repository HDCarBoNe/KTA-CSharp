using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCatapulte
{
    public class ListeObjets<O,P>
    {
        private O objet;
        private P poids;

        public ListeObjets(O NewObjet, P NewPoids)
        {
            this.objet = NewObjet;
            int Poids = Convert.ToInt32(NewPoids);
            if (Poids > 40)
            {
                Console.WriteLine("Le poids de la pièce dépasse la limie autorisée (40)");
            }
            this.poids = NewPoids;
        }
        public override string ToString()
        {
            return "Objet : " + objet + ", Poids : " + poids;
        }
    }
}

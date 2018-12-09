using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace KtaPulte.Class
{
    public class CorpsCatapulte
    {
        //String username = "groupe11";
        //String password = "cPQzPyB5";
        Beam beam;
        Spoon spoon;
        Arm arm;
        Rope rope;

        public CorpsCatapulte()
        {
            beam = new Beam();
            spoon = new Spoon();
            rope = new Rope();
            arm = new Arm();
            beam.life = setLife(beam.nom);
            spoon.life = setLife(spoon.nom);
            rope.life = setLife(rope.nom);
            arm.life = setLife(arm.nom);
        }

        private int setLife(string nom)
        {
            string Reponse = String.Empty;
            //StreamReader Sr = null;
            int life = 0;
            Console.WriteLine("https://dev18504.service-now.com/api/20557/catapulte/getlife2?target=" + nom + "");
            /*try
            {
                HttpWebRequest Req = (HttpWebRequest)WebRequest.Create("https://dev18504.service-now.com/api/20557/catapulte/getlife2?target="+nom+"");
                Req.Method = "GET"; // POST ou GET
                String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                Req.Headers.Add("Authorization", "Basic " + encoded);
                Req.Referer = "https://dev18504.service-now.com/api/20557/catapulte/getlife2?target="+nom+"";
                Req.ContentType = "application/x-www-form-urlencoded"; // La plupart du temps

                Sr = new StreamReader(((HttpWebResponse)Req.GetResponse()).GetResponseStream());
                Reponse = Sr.ReadToEnd(); // On choppe la réponse
                Sr.Close(); // Et on ferme
            }
            catch (Exception e) // En cas d'exception
            {


                Console.WriteLine(e.Message + "\r\n\r\nL'application va maintenant se terminer...");

                //return null;
            }*
            //Extraction de l'entier contenu dans reponse
            Regex rx = new Regex(@"\b*\d+(,?|.?)\d*\b");
            MatchCollection matches = rx.Matches(Reponse);
            foreach (Match m in matches)
            {
                life = int.Parse(m.Value);
            }*/
            return life;
        }

        public int getLife(string nom)
        {
            List<int> lifes = listLifes(beam, rope, spoon, arm);
            switch (nom)
            {
                case "Beam":
                    return lifes[0];
                case "Rope":
                    return lifes[1];
                case "Spoon":
                    return lifes[2];
                case "Arm":
                    return lifes[3];
                default:
                    return -1;
            }
        }

        private List<int> listLifes(Beam b, Rope r, Spoon s, Arm a)
        {
            List<int> Lifes = new List<int>();
            Lifes.Add(b.life);
            Lifes.Add(r.life);
            Lifes.Add(s.life);
            Lifes.Add(a.life);
            return Lifes;
        }
    }
}
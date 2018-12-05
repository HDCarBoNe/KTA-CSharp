using System;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
namespace KtaPulte.Class
{
    public class Beam
    {
        private int BeamLife;
        public int setLifeBeam()
        {
            String username = "groupe11";
            String password = "cPQzPyB5";
            string Reponse = String.Empty;
            StreamReader Sr = null;
            int life = -1;

            try
            {
                HttpWebRequest Req = (HttpWebRequest)WebRequest.Create("https://dev18504.service-now.com/api/20557/catapulte/getlife2?target=beam");
                Req.Method = "GET"; // POST ou GET
                String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                Req.Headers.Add("Authorization", "Basic " + encoded);
                Req.Referer = "https://dev18504.service-now.com/api/20557/catapulte/getlife2?target=beam";
                Req.ContentType = "application/x-www-form-urlencoded"; // La plupart du temps

                Sr = new StreamReader(((HttpWebResponse)Req.GetResponse()).GetResponseStream());
                Reponse = Sr.ReadToEnd(); // On choppe la réponse
                Sr.Close(); // Et on ferme
            }
            catch (Exception e) // En cas d'exception
            {


                Console.WriteLine(e.Message + "\r\n\r\nL'application va maintenant se terminer...");

                //return null;
            }
            //Extraction de l'entier contenu dans reponse
            Regex rx = new Regex(@"\b*\d+(,?|.?)\d*\b");
            MatchCollection matches = rx.Matches(Reponse);
            foreach (Match m in matches)
            {
                life = int.Parse(m.Value);
            }

            return BeamLife = life;
        }

        public int getLifeBeam()
        {
            return BeamLife;
        }

        public int setDamageBeam(int damage)
        {
            BeamLife -= damage;
            Console.WriteLine("Il reste " + BeamLife + " de vie a la corde");
            return BeamLife;
        }
    }
}

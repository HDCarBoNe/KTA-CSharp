using System;
using System.Net;
using System.IO;
namespace KtaPulte.Class
{
    public class CorpsCatapulte : Spoon
    {
        private int lifeBody;
        public int setLifeBody()
        {
            String username = "groupe11";
            String password = "cPQzPyB5";
            string Reponse = String.Empty;
            StreamReader Sr = null;


            try
            {
                HttpWebRequest Req = (HttpWebRequest)WebRequest.Create("https://dev18504.service-now.com/api/20557/catapulte/getlife2?target=Body");
                Req.Method = "GET"; // POST ou GET
                String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                Req.Headers.Add("Authorization", "Basic " + encoded);
                Req.Referer = "https://dev18504.service-now.com/api/20557/catapulte/getlife2?target=Body";
                Req.ContentType = "application/x-www-form-urlencoded"; // La plupart du temps

                Sr = new StreamReader(((HttpWebResponse)Req.GetResponse()).GetResponseStream());
                Reponse = Sr.ReadToEnd(); // On choppe la réponse
                Sr.Close(); // Et on ferme
            }
            catch (Exception e) // En cas d'exception
            {


                Console.WriteLine(e.Message + "\r\n\r\nL'application va maintenant se terminer...");

                //return;
            }
            Console.WriteLine(Reponse);
            return lifeBody= 40;
        }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConnexion;


namespace ModeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Connexion.Connect("modeconnexion");
                //Dictionary<string, string> Dico = new Dictionary<string, string>();
                //Dico = Connexion.getChamps_table("etudiant");
                //foreach (KeyValuePair<string, string> d in Dico)
                //{
                //    Console.WriteLine("Clé: {0}, Type: {1}", d.Key, d.Value);
                //}

                Etudiant e = new Etudiant();
                e.Code = "code3";
                e.nom = "ali";
                e.prenom = "rach";
                e.niveau = "ap2";
                e.code_Fil = "fil2";
                //e.id = 1;
                //if (e.save() != 0)
                //    Console.WriteLine("Insertion ou modification effectuee !!!!!!!");
                //else
                //    Console.WriteLine("Identifiant inexistant dans la base de donnees");
                //Console.WriteLine( e.find());
                //Console.WriteLine(e.delete()); 
                //List<dynamic> l = new List<dynamic>();
                //l = e.All();
                //foreach (dynamic l in )
                //{
                //    Console.WriteLine(l);
                //}

                //List<List<dynamic>> liste = new List<List<dynamic>>();
                List<dynamic> liste = new List<dynamic>();
                liste = Etudiant.All<Etudiant>(e);
                foreach (Etudiant l in liste)
                {
                    Console.WriteLine(l);
                }

                //Dictionary<string, object> etu = new Dictionary<string, object>();
                //etu.Add("Code", "code1");
                //List<dynamic> eleve = new List<dynamic>();
                //eleve = Etudiant.select<Etudiant>(etu);
                //foreach (var m in eleve)
                //    foreach (var x in m)
                //        Console.WriteLine(x);

                //Dictionary<string, object> etu = new Dictionary<string, object>();
                //etu.Add("Code", "code2");
                //List<dynamic> l = new List<dynamic>();
                //l = e.Select(etu);
                //foreach (var m in l)
                //    foreach (var x in m)
                //        Console.WriteLine(x);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

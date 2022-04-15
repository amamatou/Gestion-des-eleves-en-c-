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
                //Connexion.Connect("modeconnexion","localhost", "root", "");
                Connexion.Connect("modeconnecte", "MHAO\\SQLEXPRESS", "", "");
                //Dictionary<string, string> Dico = new Dictionary<string, string>();
                //Dico = Connexion.getChamps_table("etudiant");
                //foreach (KeyValuePair<string, string> d in Dico)
                //{
                //    Console.WriteLine("Clé: {0}, Type: {1}", d.Key, d.Value);
                //}

                Etudiant e = new Etudiant();
                //e.Code = "code3";
                //e.nom = "ali";
                //e.prenom = "rach";
                //e.niveau = "ap2";
                //e.code_Fil = "fil2";

                e.Code = "1";
                e.nom = "mahamat";
                e.prenom = "alamine";
                e.niveau = "4e annee";
                e.code_Fil = "ginf";

                //*************TEST DE LA METHODE save()*************//
                //e.id = 1;
                //if (e.save() != 0)
                //    Console.WriteLine("Insertion ou modification effectuee !!!!!!!");
                //else
                //    Console.WriteLine("Identifiant inexistant dans la base de donnees");


                //*************TEST DE LA METHODE save(procedure)*************//
                e.save("Etudiant_Insert");
                e.id = 1;
                e.save("Etudiant_update");

                //*************TEST DE LA METHODE find()*************//
                //Console.WriteLine( e.find());



                //*************TEST DE LA METHODE delete()*************//
                //Console.WriteLine(e.delete()); 



                //*************TEST DE LA METHODE All()*************//
                //List<dynamic> list = new List<dynamic>();
                //list = e.All();
                //foreach (var l in list)
                //{
                //    foreach (var x in l)
                //        Console.WriteLine(x);
                //    Console.WriteLine("===============================================");
                //}



                //*************TEST DE LA METHODE STATIC All()*************//
                // List<List<dynamic>> liste = new List<List<dynamic>>();

                //List<dynamic> liste = new List<dynamic>();
                //liste = Etudiant.All<Etudiant>(e);
                //foreach (Etudiant l in liste)
                //{
                //    foreach (var x in l)
                //        Console.WriteLine(x);
                //    Console.WriteLine("===============================================");
                //}




                //*************TEST DE LA METHODE Select()*************//
                //Dictionary<string, object> etu = new Dictionary<string, object>();
                //etu.Add("Code", "code2");
                //List<dynamic> l = new List<dynamic>();
                //l = e.Select(etu);
                //foreach (var m in l)
                //{
                //    foreach (var x in m)
                //        Console.WriteLine(x);
                //    Console.WriteLine("===============================================");
                //}



                //*************TEST DE LA METHODE STATIC Select()*************//
                //Dictionary<string, object> etu = new Dictionary<string, object>();
                //etu.Add("Code", "code1");
                //List<dynamic> eleve = new List<dynamic>();
                //eleve = Etudiant.select<Etudiant>(etu);
                //foreach (var m in eleve)
                //{
                //    foreach (var x in m)
                //        Console.WriteLine(x);
                //Console.WriteLine("===============================================");
                //}



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

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
                Connexion.Connect("modeconnexion","localhost", "root", "");
                //Connexion.Connect("modeconnecte", "MHAO\\SQLEXPRESS", "", "");
                //Dictionary<string, string> Dico = new Dictionary<string, string>();
                //Dico = Connexion.getChamps_table("etudiant");
                //foreach (KeyValuePair<string, string> d in Dico)
                //{
                //    Console.WriteLine("Clé: {0}, Type: {1}", d.Key, d.Value);
                //}

                Etudiant e = new Etudiant();
                //e.Code = "code3";
                //e.nom = "ali";
                //e.prenom = "rachid";
                //e.niveau = "ap2";
                //e.code_Fil = "fil2";

                e.Code = "code2";
                e.nom = "mahamat";
                e.prenom = "alamine";
                e.niveau = "3e annee";
                e.code_Fil = "ginf";

                //*************TEST DE LA METHODE save()*************//
                //e.id = 1;
                //if (e.save() != 0)
                //    Console.WriteLine("Insertion ou modification effectuee !!!!!!!");
                //else
                //    Console.WriteLine("Identifiant inexistant dans la base de donnees");


                //*************TEST DE LA METHODE save(procedure)*************//
                //if (e.save("Etudiant_Insert") != 0)
                //    Console.WriteLine("Insertion effectuee !!!!!!!");
                //if (e.save("Etudiant_update") != 0)
                //    Console.WriteLine("Modification effectuee !!!!!!!");



                //*************TEST DE LA METHODE find()*************//
                //Console.WriteLine(e.find());
                //dynamic e2 = new Etudiant();
                //e2 = e.find();
                //Etudiant.Afficher(e2);
                //Etudiant e2 = (Etudiant)e.find();



                //*************TEST DE LA METHODE static find()*************//
                //Console.WriteLine( Etudiant.find());



                //*************TEST DE LA METHODE delete()*************//
                //if(e.delete())
                //  Console.WriteLine("Suppression effectuee !!!!!!");


                //*************TEST DE LA METHODE delete(procedure)*************//
                //if (e.delete("Etudiant_Delete") != 0)
                //    Console.WriteLine("Suppression effectuee !!!!!!");



                //*************TEST DE LA METHODE All()*************//
                //List<dynamic> liste = new List<dynamic>();
                //liste = e.All();
                //Etudiant.Afficher(liste);



                //*************TEST DE LA METHODE STATIC All()*************//
                ////List<List<dynamic>> liste = new List<List<dynamic>>();
                //List<dynamic> liste = new List<dynamic>();
                //liste = Etudiant.All<Etudiant>(e);
                //Etudiant.Afficher(liste);




                //*************TEST DE LA METHODE Select()*************//
                //Dictionary<string, object> etu = new Dictionary<string, object>();
                //etu.Add("Code", "code1");
                //List<dynamic> liste = new List<dynamic>();
                //liste = e.Select(etu);
                //Etudiant.Afficher(l);



                //*************TEST DE LA METHODE STATIC Select()*************//
                //Dictionary<string, object> etu = new Dictionary<string, object>();
                //etu.Add("Code", "code1");
                //List<dynamic> liste = new List<dynamic>();
                //liste = Etudiant.Select<Etudiant>(etu);
                //Etudiant.Afficher(liste);



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

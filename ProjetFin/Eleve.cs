using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFin
{
    class Eleve : Model
    {
        private string nom;
        private string prenom;
        private string code_fil;
        private string code_elev;
        private string niveau;
       
        public string Code_fil { get => code_fil; set => code_fil = value; }
        public string Code_Elev { get => code_elev; set => code_elev = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public Eleve(string nom, string prenom, string niveau, string codeElev, string Code_fil)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.niveau = niveau;
            this.code_elev = codeElev;
            this.code_fil = Code_fil;
        }
        public Eleve() { }
    }
}

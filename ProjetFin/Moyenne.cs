using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFin
{
    class Moyenne : Model
    {
        private string code_elev;
        private string niveau;
        private float moyenne;
        private string code_fil;
        public string Code_elev { get => code_elev; set => code_elev = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public float Moyennee { get => moyenne; set => moyenne = value; }
        public string Code_fil { get => code_fil; set => code_fil = value; }
        public Moyenne(string code_elev, string niveau, float moyenne, string code_fil)
        {
            this.code_elev = code_elev;
            this.niveau = niveau;
            this.moyenne = moyenne;
            this.code_fil = code_fil;
        }
        public Moyenne() { }
    }
}

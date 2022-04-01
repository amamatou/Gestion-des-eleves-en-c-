using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFin
{
    class Module : Model
    {
        private string code_mod;
        private string designation;
        private string niveau;
        private string semestre;
        private string code_fil;
        public string Code_mod { get => code_mod; set => code_mod = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        public string Code_fil { get => code_fil; set => code_fil = value; }
        public Module(string code_mod, string designation, string niveau, string semestre, string codefil)
        {
            this.code_mod = code_mod;
            this.designation = designation;
            this.niveau = niveau;
            this.semestre = semestre;
            this.code_fil = codefil;
        }
        public Module() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFin
{
    class Filiere : Model
    {
        private string code_fil;
        private string designation;
        public string Code_fil { get => code_fil; set => code_fil = value; }
        public string Designation { get => designation; set => designation = value; }
        public Filiere(string code = null, string designation = null)
        {
            this.code_fil = code;
            this.designation = designation;
        }
        public Filiere() { }
    }
}

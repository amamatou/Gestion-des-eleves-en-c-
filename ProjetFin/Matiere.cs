using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFin
{
    class Matiere : Model
    {
        private string code_mat;
        private string designation;
        private double vh;
        private string code_mod;
        public string Code_mat { get => code_mat; set => code_mat = value; }
        public string Designation { get => designation; set => designation = value; }
        public double VH { get => vh; set => vh = value; }
        public string Code_mod { get => code_mod; set => code_mod = value; }
        public Matiere(string code_mat, string designation, double vh, string code_mod)
        {
            this.code_mat = code_mat;
            this.designation = designation;
            this.vh = vh;
            this.code_mod = code_mod;
        }
        public Matiere() { }
    }
}

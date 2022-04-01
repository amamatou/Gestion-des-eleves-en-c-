using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFin
{
    class Note : Model
    {
        private string code_elev;
        private string code_mat;
        private float note;
        public string Code_elev { get => code_elev; set => code_elev = value; }
        public string Code_mat { get => code_mat; set => code_mat = value; }
        public float Notee { get => note; set => note = value; }
        public Note(string code_elev, string code_mat, float note)
        {
            this.code_elev = code_elev;
            this.code_mat = code_mat;
            this.note = note;
        }
        public Note() { }
    }
}

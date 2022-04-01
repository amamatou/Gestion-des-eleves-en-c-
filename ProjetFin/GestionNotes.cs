using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using TestConnexion;

namespace ProjetFin
{
    public partial class GestionNotes : Form
    {
        Note note ;
        public GestionNotes()
        {
            note = new Note();
            InitializeComponent();
        }
        public GestionNotes(string code)
        {
            InitializeComponent();
            textBox1.Text = code;
            textBox1.Enabled = false;
            Get_Matieres(code);


        }
        private void Clear()
        {
           textBox1.Text = " ";
           textBox2.Text = " ";
           comboBox1.Text = " ";
        }
        private void  Get_Matieres(string code_elev)
        {

            Eleve L = Eleve.find(code_elev);
            foreach (Eleve E in L)
            {
                Module F = Module.find(E.Code_fil);
                foreach (Module MO in F)
                {
                    Matiere Mat = Matiere.find(MO.Code_mod);
                    foreach (Matiere MA in Mat)
                    {
                        comboBox1.Items.Add(MA.Code_mat);
                    }
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

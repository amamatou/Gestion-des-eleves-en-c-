using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestConnexion;

namespace TP4
{
    public partial class etudiants : Form
    {
        public etudiants()
        {
            InitializeComponent();
            Connexion.Connect("modeconnexion");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
        public static void ouvrir()
        {
            etudiants e = new etudiants();
            e.Show();
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            text_code.Clear();
            text_nom.Clear();
            text_prenom.Clear();
            comboBox_filiere.ResetText();
            comboBox_niveau.ResetText();

        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {

        }

        private void button_modifier_Click(object sender, EventArgs e)
        {

        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {

        }
    }
}

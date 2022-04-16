using gestion_ensat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_etudiant;


namespace ensa
{
    public partial class Gestion_Etudiants : Form
    {
        Eleve eleve1;
        public Gestion_Etudiants()
        {
            eleve1 = new Eleve();
            Connexion.Connect("modeconnexion", "localhost", "root", "");
           
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void button_nouveau_Click_1(object sender, EventArgs e)
        {
            text_code.Text= "";
           text_prenom.Text = "";
            text_nom.Text = "";
            combo_filiere.Text = "";
            combo_niveau.Text = "";
            
        }
        private void loadNiv()
        {
                for(int i=1; i < 4; i++)
                {               
                    combo_niveau.Items.Add(combo_filiere.Text + i);

                    if (combo_filiere.Text == "AP" && i == 2)
                        break;
                }
        
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            eleve1.code =""+ text_code.Text;
            eleve1.nom = "" + text_nom.Text;
            eleve1.prenom = "" + text_prenom.Text;
            eleve1.code_fil = combo_filiere.Text;
            eleve1.niveau = combo_niveau.Text;

            
            if (eleve1.save() != 0)
            {
                MessageBox.Show("eleve ajouté avec succes ");
                button_nouveau_Click_1(sender, e);
            }
            else
            {
                MessageBox.Show("erreur dans l'ajout ");
                button_nouveau_Click_1(sender, e);
            }

        }

        private void combo_filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_niveau.Items.Clear();
            loadNiv();
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code", text_code.Text);
           List<dynamic> listt = Model.select<Eleve>(dico);
          MessageBox.Show( "" +listt.ElementAt(0));
            //eleve1.save();

           
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {

            //List List<dynamic> listt = Model.select<Eleve>(dico);

        }
    }
}

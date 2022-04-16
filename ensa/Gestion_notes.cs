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

namespace ensa
{
    public partial class Gestion_notes : Form
    {
        Notes n; 
        public Gestion_notes()
        {
            n = new Notes();
            Connexion.Connect("gestion_ensat");
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code_el", txt_code.Text);
            dico.Add("code_mat", combo_matiere.Text);
            List<dynamic> listt = Model.select<Notes>(dico);

    

            n.code_el = txt_code.Text;
            n.code_mat = combo_matiere.Text;
            n.note = Int32.Parse(txt_notes.Text);
            foreach (var x in listt)
            {  foreach (var d in x)
                {
                    n.id=(int)d;
                    break;

                }
                break;
        }
     
            
          if( n.save()!=0)
            MessageBox.Show("note changé avec success ");
          else
                MessageBox.Show("erreur de modification ");
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n.code_el = txt_code.Text;
            n.code_mat = combo_matiere.Text;
            n.note = Int32.Parse(txt_notes.Text);
            if (n.save() != 0)
            {
                MessageBox.Show("note ajouté avec success");
            }
            else
                MessageBox.Show("verifier vos données ! erreur dans l'ajout ");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

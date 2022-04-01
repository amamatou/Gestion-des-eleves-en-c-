using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeGraphique
{
    public partial class page1 : Form
    {
        public page1()
        {
            InitializeComponent();
        }

        private void page1_Load(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "C:\\Users\\user\\source\\repos\\TP4\\ensa.png";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize; 
            this.Controls.Add(pb1);

        }

        private void filToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etudiant_US child = new Etudiant_US();
            //child.MdiParent = this;
            child.Select();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notes child = new notes();
           //child.MdiParent = this;
           //child.Show();
            child.ShowDialog();
        }

        private void bilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilan child = new Bilan();
            /*child.MdiParent = this;
            child.Show();*/
            child.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // page1
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "page1";
            this.Load += new System.EventHandler(this.page1_Load_1);
            this.ResumeLayout(false);

        }

        private void page1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

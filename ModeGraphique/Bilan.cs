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
    public partial class Bilan : Form
    {
        public Bilan()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Bilan
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "Bilan";
            this.Load += new System.EventHandler(this.Bilan_Load);
            this.ResumeLayout(false);

        }

        private void Bilan_Load(object sender, EventArgs e)
        {

        }
    }
}

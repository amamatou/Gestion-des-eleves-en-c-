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
    public partial class notes : Form
    {
        public notes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // notes
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "notes";
            this.Load += new System.EventHandler(this.notes_Load);
            this.ResumeLayout(false);

        }

        private void notes_Load(object sender, EventArgs e)
        {

        }
    }
}


namespace ensa
{
    partial class Gestion_Etudiants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_code = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_code = new System.Windows.Forms.TextBox();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_nom = new System.Windows.Forms.CheckBox();
            this.button_modifier = new System.Windows.Forms.Button();
            this.text_prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_prenom = new System.Windows.Forms.CheckBox();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_filiere = new System.Windows.Forms.CheckBox();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_niveau = new System.Windows.Forms.CheckBox();
            this.button_notes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeElev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeFil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_filiere = new System.Windows.Forms.ComboBox();
            this.combo_niveau = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_code
            // 
            this.checkBox_code.AutoSize = true;
            this.checkBox_code.Location = new System.Drawing.Point(293, 40);
            this.checkBox_code.Name = "checkBox_code";
            this.checkBox_code.Size = new System.Drawing.Size(22, 21);
            this.checkBox_code.TabIndex = 0;
            this.checkBox_code.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_code
            // 
            this.text_code.Location = new System.Drawing.Point(124, 40);
            this.text_code.Name = "text_code";
            this.text_code.Size = new System.Drawing.Size(147, 26);
            this.text_code.TabIndex = 2;
            // 
            // button_nouveau
            // 
            this.button_nouveau.Location = new System.Drawing.Point(457, 35);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(198, 37);
            this.button_nouveau.TabIndex = 3;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click_1);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(457, 78);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(198, 37);
            this.button_ajouter.TabIndex = 7;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(124, 97);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(147, 26);
            this.text_nom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox_nom
            // 
            this.checkBox_nom.AutoSize = true;
            this.checkBox_nom.Location = new System.Drawing.Point(293, 97);
            this.checkBox_nom.Name = "checkBox_nom";
            this.checkBox_nom.Size = new System.Drawing.Size(22, 21);
            this.checkBox_nom.TabIndex = 4;
            this.checkBox_nom.UseVisualStyleBackColor = true;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(457, 121);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(198, 37);
            this.button_modifier.TabIndex = 11;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // text_prenom
            // 
            this.text_prenom.Location = new System.Drawing.Point(124, 159);
            this.text_prenom.Name = "text_prenom";
            this.text_prenom.Size = new System.Drawing.Size(147, 26);
            this.text_prenom.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prénom";
            // 
            // checkBox_prenom
            // 
            this.checkBox_prenom.AutoSize = true;
            this.checkBox_prenom.Location = new System.Drawing.Point(293, 159);
            this.checkBox_prenom.Name = "checkBox_prenom";
            this.checkBox_prenom.Size = new System.Drawing.Size(22, 21);
            this.checkBox_prenom.TabIndex = 8;
            this.checkBox_prenom.UseVisualStyleBackColor = true;
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(457, 164);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(198, 37);
            this.button_supprimer.TabIndex = 15;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filière";
            // 
            // checkBox_filiere
            // 
            this.checkBox_filiere.AutoSize = true;
            this.checkBox_filiere.Location = new System.Drawing.Point(293, 214);
            this.checkBox_filiere.Name = "checkBox_filiere";
            this.checkBox_filiere.Size = new System.Drawing.Size(22, 21);
            this.checkBox_filiere.TabIndex = 12;
            this.checkBox_filiere.UseVisualStyleBackColor = true;
            // 
            // button_rechercher
            // 
            this.button_rechercher.Location = new System.Drawing.Point(457, 209);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(198, 37);
            this.button_rechercher.TabIndex = 19;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.UseVisualStyleBackColor = true;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Niveau";
            // 
            // checkBox_niveau
            // 
            this.checkBox_niveau.AutoSize = true;
            this.checkBox_niveau.Location = new System.Drawing.Point(293, 268);
            this.checkBox_niveau.Name = "checkBox_niveau";
            this.checkBox_niveau.Size = new System.Drawing.Size(22, 21);
            this.checkBox_niveau.TabIndex = 16;
            this.checkBox_niveau.UseVisualStyleBackColor = true;
            // 
            // button_notes
            // 
            this.button_notes.Location = new System.Drawing.Point(457, 252);
            this.button_notes.Name = "button_notes";
            this.button_notes.Size = new System.Drawing.Size(198, 37);
            this.button_notes.TabIndex = 20;
            this.button_notes.Text = "Gestion des notes";
            this.button_notes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeElev,
            this.nom,
            this.prenom,
            this.niveau,
            this.codeFil});
            this.dataGridView1.Location = new System.Drawing.Point(38, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(724, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // codeElev
            // 
            this.codeElev.HeaderText = "codeElev";
            this.codeElev.MinimumWidth = 8;
            this.codeElev.Name = "codeElev";
            this.codeElev.Width = 150;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 8;
            this.nom.Name = "nom";
            this.nom.Width = 150;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.MinimumWidth = 8;
            this.prenom.Name = "prenom";
            this.prenom.Width = 150;
            // 
            // niveau
            // 
            this.niveau.HeaderText = "niveau";
            this.niveau.MinimumWidth = 8;
            this.niveau.Name = "niveau";
            this.niveau.Width = 150;
            // 
            // codeFil
            // 
            this.codeFil.HeaderText = "code_Fil";
            this.codeFil.MinimumWidth = 8;
            this.codeFil.Name = "codeFil";
            this.codeFil.Width = 150;
            // 
            // combo_filiere
            // 
            this.combo_filiere.FormattingEnabled = true;
            this.combo_filiere.Items.AddRange(new object[] {
            "AP",
            "GINF",
            "GIL",
            "GSTR",
            "G3EI",
            "GSEA"});
            this.combo_filiere.Location = new System.Drawing.Point(124, 210);
            this.combo_filiere.Name = "combo_filiere";
            this.combo_filiere.Size = new System.Drawing.Size(147, 28);
            this.combo_filiere.TabIndex = 22;
            this.combo_filiere.SelectedIndexChanged += new System.EventHandler(this.combo_filiere_SelectedIndexChanged);
            // 
            // combo_niveau
            // 
            this.combo_niveau.FormattingEnabled = true;
            this.combo_niveau.Location = new System.Drawing.Point(124, 261);
            this.combo_niveau.Name = "combo_niveau";
            this.combo_niveau.Size = new System.Drawing.Size(147, 28);
            this.combo_niveau.TabIndex = 23;
            // 
            // Gestion_Etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.combo_niveau);
            this.Controls.Add(this.combo_filiere);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_notes);
            this.Controls.Add(this.button_rechercher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_niveau);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_filiere);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.text_prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_prenom);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_nom);
            this.Controls.Add(this.button_nouveau);
            this.Controls.Add(this.text_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_code);
            this.Name = "Gestion_Etudiants";
            this.Text = "Gestion_Etudiants";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_code;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_nom;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.TextBox text_prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_prenom;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_filiere;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_niveau;
        private System.Windows.Forms.Button button_notes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeElev;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeFil;
        private System.Windows.Forms.ComboBox combo_filiere;
        private System.Windows.Forms.ComboBox combo_niveau;
    }
}
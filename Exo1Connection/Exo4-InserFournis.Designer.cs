namespace Exo1Connection
{
    partial class Exo4_InserFournis
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
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.B_ajout = new System.Windows.Forms.Button();
            this.b_annuler = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(36, 65);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(434, 20);
            this.tb_nom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adresse";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(36, 126);
            this.tb_adresse.Multiline = true;
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(434, 59);
            this.tb_adresse.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code Postal";
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(36, 223);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(168, 20);
            this.tb_cp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ville";
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(219, 223);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(251, 20);
            this.tb_ville.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact";
            // 
            // tb_contact
            // 
            this.tb_contact.Location = new System.Drawing.Point(36, 277);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(434, 20);
            this.tb_contact.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Indice de satisfaction";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(151, 320);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(319, 45);
            this.trackBar.TabIndex = 11;
            this.trackBar.Value = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "NA";
            // 
            // B_ajout
            // 
            this.B_ajout.Location = new System.Drawing.Point(300, 372);
            this.B_ajout.Name = "B_ajout";
            this.B_ajout.Size = new System.Drawing.Size(75, 23);
            this.B_ajout.TabIndex = 13;
            this.B_ajout.Text = "Ajouter";
            this.B_ajout.UseVisualStyleBackColor = true;
            this.B_ajout.Click += new System.EventHandler(this.B_ajout_Click);
            // 
            // b_annuler
            // 
            this.b_annuler.Location = new System.Drawing.Point(395, 372);
            this.b_annuler.Name = "b_annuler";
            this.b_annuler.Size = new System.Drawing.Size(75, 23);
            this.b_annuler.TabIndex = 14;
            this.b_annuler.Text = "Annuler";
            this.b_annuler.UseVisualStyleBackColor = true;
            this.b_annuler.Click += new System.EventHandler(this.b_annuler_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "10";
            // 
            // Exo4_InserFournis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 407);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.b_annuler);
            this.Controls.Add(this.B_ajout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_contact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nom);
            this.Name = "Exo4_InserFournis";
            this.Text = "Ajout Fournisseur";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button B_ajout;
        private System.Windows.Forms.Button b_annuler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
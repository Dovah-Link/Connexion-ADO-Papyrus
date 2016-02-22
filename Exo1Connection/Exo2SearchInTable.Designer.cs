namespace Exo1Connection
{
    partial class Exo2SearchInTable
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_codefournis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_nom);
            this.groupBox1.Controls.Add(this.tb_contact);
            this.groupBox1.Controls.Add(this.tb_ville);
            this.groupBox1.Controls.Add(this.tb_adresse);
            this.groupBox1.Controls.Add(this.tb_cp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Fournisseur";
            // 
            // TB_codefournis
            // 
            this.TB_codefournis.Location = new System.Drawing.Point(104, 21);
            this.TB_codefournis.Name = "TB_codefournis";
            this.TB_codefournis.Size = new System.Drawing.Size(206, 20);
            this.TB_codefournis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code fournisseur";
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(104, 47);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(75, 23);
            this.b_search.TabIndex = 3;
            this.b_search.Text = "Cherchez";
            this.b_search.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CP / Ville";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nom";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Enabled = false;
            this.tb_adresse.Location = new System.Drawing.Point(68, 69);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(206, 20);
            this.tb_adresse.TabIndex = 7;
            // 
            // tb_ville
            // 
            this.tb_ville.Enabled = false;
            this.tb_ville.Location = new System.Drawing.Point(139, 105);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(135, 20);
            this.tb_ville.TabIndex = 8;
            // 
            // tb_cp
            // 
            this.tb_cp.Enabled = false;
            this.tb_cp.Location = new System.Drawing.Point(68, 105);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(46, 20);
            this.tb_cp.TabIndex = 9;
            // 
            // tb_contact
            // 
            this.tb_contact.Enabled = false;
            this.tb_contact.Location = new System.Drawing.Point(68, 141);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(206, 20);
            this.tb_contact.TabIndex = 10;
            this.tb_contact.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tb_nom
            // 
            this.tb_nom.Enabled = false;
            this.tb_nom.Location = new System.Drawing.Point(68, 33);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(206, 20);
            this.tb_nom.TabIndex = 11;
            // 
            // Exo2SearchInTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 303);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_codefournis);
            this.Controls.Add(this.groupBox1);
            this.Name = "Exo2SearchInTable";
            this.Text = "Exo2SearchInTable";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_codefournis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_search;
    }
}
namespace Exo1Connection
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_serveur = new System.Windows.Forms.TextBox();
            this.TB_BDD = new System.Windows.Forms.TextBox();
            this.B_Connect = new System.Windows.Forms.Button();
            this.B_deco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B_quit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_EtatConnect = new System.Windows.Forms.Label();
            this.tb_erreur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_serveur
            // 
            this.tb_serveur.AccessibleDescription = "Application.Exit();";
            this.tb_serveur.Location = new System.Drawing.Point(136, 28);
            this.tb_serveur.Name = "tb_serveur";
            this.tb_serveur.Size = new System.Drawing.Size(171, 20);
            this.tb_serveur.TabIndex = 0;
            // 
            // TB_BDD
            // 
            this.TB_BDD.AccessibleDescription = "Application.Exit();";
            this.TB_BDD.Location = new System.Drawing.Point(136, 73);
            this.TB_BDD.Name = "TB_BDD";
            this.TB_BDD.Size = new System.Drawing.Size(171, 20);
            this.TB_BDD.TabIndex = 1;
            // 
            // B_Connect
            // 
            this.B_Connect.Location = new System.Drawing.Point(136, 130);
            this.B_Connect.Name = "B_Connect";
            this.B_Connect.Size = new System.Drawing.Size(75, 23);
            this.B_Connect.TabIndex = 2;
            this.B_Connect.Text = "Connexion";
            this.B_Connect.UseVisualStyleBackColor = true;
            this.B_Connect.Click += new System.EventHandler(this.B_Connect_Click);
            // 
            // B_deco
            // 
            this.B_deco.Location = new System.Drawing.Point(227, 130);
            this.B_deco.Name = "B_deco";
            this.B_deco.Size = new System.Drawing.Size(80, 23);
            this.B_deco.TabIndex = 3;
            this.B_deco.Text = "Deconnexion";
            this.B_deco.UseVisualStyleBackColor = true;
            this.B_deco.Click += new System.EventHandler(this.B_deco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SERVEUR :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "BASES DE DONEES : ";
            // 
            // B_quit
            // 
            this.B_quit.Location = new System.Drawing.Point(227, 159);
            this.B_quit.Name = "B_quit";
            this.B_quit.Size = new System.Drawing.Size(80, 23);
            this.B_quit.TabIndex = 6;
            this.B_quit.Text = "Quitter";
            this.B_quit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Etat de la connexion : ";
            // 
            // LBL_EtatConnect
            // 
            this.LBL_EtatConnect.AutoSize = true;
            this.LBL_EtatConnect.Location = new System.Drawing.Point(151, 195);
            this.LBL_EtatConnect.Name = "LBL_EtatConnect";
            this.LBL_EtatConnect.Size = new System.Drawing.Size(39, 13);
            this.LBL_EtatConnect.TabIndex = 9;
            this.LBL_EtatConnect.Text = "Closed";
            // 
            // tb_erreur
            // 
            this.tb_erreur.Enabled = false;
            this.tb_erreur.Location = new System.Drawing.Point(16, 211);
            this.tb_erreur.Multiline = true;
            this.tb_erreur.Name = "tb_erreur";
            this.tb_erreur.Size = new System.Drawing.Size(291, 157);
            this.tb_erreur.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(322, 380);
            this.Controls.Add(this.tb_erreur);
            this.Controls.Add(this.LBL_EtatConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_quit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_deco);
            this.Controls.Add(this.B_Connect);
            this.Controls.Add(this.TB_BDD);
            this.Controls.Add(this.tb_serveur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_serveur;
        private System.Windows.Forms.TextBox TB_BDD;
        private System.Windows.Forms.Button B_Connect;
        private System.Windows.Forms.Button B_deco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_quit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_EtatConnect;
        private System.Windows.Forms.TextBox tb_erreur;
    }
}


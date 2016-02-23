using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exo1Connection
{
    public partial class Exo2SearchInTable : Form
    {

        public Exo2SearchInTable()
        {
            InitializeComponent();
        }
        private void b_search_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=.; database=test; integrated security=true");

            try
            {
                connect.Open();
                try {
                        SqlCommand requete = new SqlCommand("select NOMFOU, RUEFOU, POSFOU, VILFOU, CONFOU from FOURNIS where NUMFOU=" + Convert.ToInt32(TB_codefournis.Text), connect);
                        SqlDataReader resultat = requete.ExecuteReader();
                        while (resultat.Read())
                        {
                            tb_nom.Text = (resultat["NOMFOU"].ToString());
                            tb_adresse.Text = (resultat["RUEFOU"].ToString());
                            tb_cp.Text = (resultat["POSFOU"].ToString());
                            tb_ville.Text = (resultat["VILFOU"].ToString());
                            tb_contact.Text = (resultat["CONFOU"].ToString());
                        }
                }
                catch
                {
                    MessageBox.Show("Impossible de trouver les donnees correspondant à " + TB_codefournis.Text + "\nVeuillez recommencer votre saisie !", "Erreur");
                    TB_codefournis.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Connexion à la base de donnees impossible","Erreur");
            }
            connect.Close();
        }
    }
}

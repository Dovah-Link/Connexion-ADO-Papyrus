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
using System.Text.RegularExpressions;

namespace Exo1Connection
{
    public partial class Exo4_InserFournis : Form
    {
        public Exo4_InserFournis()
        {
            InitializeComponent();
        }

        private void b_annuler_Click(object sender, EventArgs e)
        {
            tb_nom.Clear();
            tb_adresse.Clear();
            tb_cp.Clear();
            tb_ville.Clear();
            tb_contact.Clear();
            trackBar.Value = 1;
        }

        private void B_ajout_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=.;integrated security=True;database = test ");
            try
            {
                connect.Open();

                try
                {
                    int max_numfou = 0;
                    SqlCommand requete2 = new SqlCommand("SELECT Max(NUMFOU) FROM FOURNIS",connect);
                    SqlDataReader res2 = requete2.ExecuteReader();
                    if (res2.Read())
                    {
                        max_numfou = Convert.ToInt32(res2[0]);
                    }
                    res2.Close();
                    string str = String.Format("INSERT INTO FOURNIS (NUMFOU, NOMFOU,RUEFOU,POSFOU,VILFOU,CONFOU,SATISF) VALUES ({0},'{1}','{2}',{3},'{4}','{5}','{6}')",max_numfou+1, tb_nom.Text, tb_adresse.Text, tb_cp.Text, tb_ville.Text, tb_contact.Text, trackBar.Value.ToString());
                    SqlCommand requete = new SqlCommand(str,connect);
                    requete.ExecuteNonQuery();
                    MessageBox.Show("Requetes reussi");
                }
                catch (Exception er)
                {
                    MessageBox.Show("" + er , "");
                }
            }
            catch
            {
                MessageBox.Show("Impossible de se connecter à la base de donnée", "Erreur");
            }
            finally
            {
                connect.Close();
            }

        }
    }
}

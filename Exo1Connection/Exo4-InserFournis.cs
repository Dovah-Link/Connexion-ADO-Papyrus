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
            SqlConnection connect = new SqlConnection("server=.;integrated security=True;database =test ");
            try
            {
                connect.Open();

                try
                {
                    int max_numfou = 0;
                    SqlCommand requete2 = new SqlCommand("SELECT Max(NUMFOU) FROM FOURNIS", connect);
                    SqlDataReader res2 = requete2.ExecuteReader();
                    if (res2.Read())
                    {
                        max_numfou = Convert.ToInt32(res2[0]);
                    }
                    res2.Close();

                    bool testcp = CPValide(tb_cp.Text);
                    bool testnom = NomValide(tb_nom.Text);
                    bool testadrs = AdrsValide(tb_adresse.Text);
                    bool testcon = ConValide(tb_contact.Text);
                    bool testville = VilleValide(tb_ville.Text);

                    if (testcp == true && testnom == true && testadrs == true && testcon == true && testville == true)
                    {
                            int a = Convert.ToInt32(tb_cp.Text);
                            string str = String.Format("INSERT INTO FOURNIS (NUMFOU, NOMFOU,RUEFOU,POSFOU,VILFOU,CONFOU,SATISF) VALUES ({0},'{1}','{2}',{3},'{4}','{5}','{6}')", max_numfou + 1, tb_nom.Text, tb_adresse.Text, a, tb_ville.Text, tb_contact.Text, trackBar.Value.ToString());
                            SqlCommand requete = new SqlCommand(str, connect);
                            requete.ExecuteNonQuery();
                            MessageBox.Show("Insertion reussi");
                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show("" + er, "");
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
        bool CPValide(string a)
        {
            bool b;
            if ((Regex.IsMatch(a, "^[0-9][0-9][0-9][0-9][0-9]$") == true))
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;

        }
        bool NomValide(string a)
        {
            bool b;
            if ((Regex.IsMatch(a, "^[a-zA-Z][a-zA-Z]*(([-]|[ ]|['])?[A-Za-z]+)*$") == true))
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
        bool AdrsValide(string a)
        {
            bool b;
            if ((Regex.IsMatch(a, "[0-9]{1,3}(?:(?:[,. ]){1}[-a-zA-Zàâäéèêëïîôöùûüç]+)+") == true))
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }

        bool VilleValide(string a)
        {
            bool b;
            if ((Regex.IsMatch(a, "^[a-zA-Z][a-zA-Z]*([ '-]?[a-zA-Z]+)*$") == true))
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
        bool ConValide(string a)
        {
            bool b;
            if ((Regex.IsMatch(a, "^[a-zA-Z][a-zA-Z]*(([-]|[ ]|['])?[A-Za-z]+)*$") == true))
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }

        private void tb_nom_TextChanged(object sender, EventArgs e)
        {
            bool testnom = NomValide(tb_nom.Text);
            if(testnom == true)
            {
                tb_nom.BackColor = Color.Green;
                tb_nom.ForeColor = Color.White;
            }
            else if (tb_nom.Text == "")
            {
                tb_nom.BackColor = Color.White;
            }
            else
            {
                tb_nom.BackColor = Color.Red;
                tb_nom.ForeColor = Color.White;
            }
        }

        private void tb_cp_TextChanged(object sender, EventArgs e)
        {
            
            bool testcp = CPValide(tb_cp.Text);
            if (testcp == true)
            {
                tb_cp.BackColor = Color.Green;
                tb_cp.ForeColor = Color.White;
            }
            else if(tb_cp.Text == "")
            {
                tb_cp.BackColor = Color.White;
            }
            else
            {
                tb_cp.BackColor = Color.Red;
                tb_cp.ForeColor = Color.White;
            }
        }

        private void tb_adresse_TextChanged(object sender, EventArgs e)
        {
            bool testadrs = AdrsValide(tb_adresse.Text);
            if (testadrs == true)
            {
                tb_adresse.BackColor = Color.Green;
                tb_adresse.ForeColor = Color.White;
            }
            else if (tb_adresse.Text == "")
            {
                tb_adresse.BackColor = Color.White;
            }
            else
            {
                tb_adresse.BackColor = Color.Red;
                tb_adresse.ForeColor = Color.White;
            }
        }

        private void tb_ville_TextChanged(object sender, EventArgs e)
        {
            bool testville = VilleValide(tb_ville.Text);
            if (testville == true)
            {
                tb_ville.BackColor = Color.Green;
                tb_ville.ForeColor = Color.White;
            }
            else if (tb_ville.Text == "")
            {
                tb_ville.BackColor = Color.White;
                tb_ville.ForeColor = Color.Black;
            }
            else
            {
                tb_ville.BackColor = Color.Red;
                tb_ville.ForeColor = Color.White;
            }
        }

        private void tb_contact_TextChanged(object sender, EventArgs e)
        {
            bool testcon = ConValide(tb_contact.Text);
            if (testcon == true)
            {
                tb_contact.BackColor = Color.Green;
                tb_contact.ForeColor = Color.White;
            }
            else if (tb_contact.Text == "")
            {
                tb_contact.BackColor = Color.White;
            }
            else
            {
                tb_contact.BackColor = Color.Red;
                tb_contact.ForeColor = Color.White;
            }
        }
    }
}

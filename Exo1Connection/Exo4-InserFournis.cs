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
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = "server=.;database = test; Integrated Security=True";
            connect.Open();
            try
            {
                string str = String.Format("INSERT INTO FOURNIS (NOMFOU,RUEFOU,POSFOU,VILFOU,CONFOU,SATISF) VALUES '{0}','{1}',{2},{3},{4},{5}", tb_nom.Text, tb_adresse.Text, tb_cp.Text, tb_ville.Text,tb_contact.Text, trackBar.Value.ToString());
            }
            catch(Exception er)
            {
                MessageBox.Show(""+er,"");
            }
            connect.Close(); 
        }
    }
}

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
            connect.Open();

 // ------------------------------------------------------------------------------------------------------------------------------------------ REQUETES

            SqlCommand req1 = new SqlCommand("select NOMFOU from FOURNIS where NUMFOU="+Convert.ToInt32(TB_codefournis.Text), connect);
            SqlDataReader resultat = req1.ExecuteReader();

            //SqlCommand req2 = new SqlCommand("select RUEFOU from FOURNIS where NUMFOU=" + Convert.ToInt32(TB_codefournis.Text), connect);
            //SqlDataReader resultat2 = req2.ExecuteReader();

// ------------------------------------------------------------------------------------------------------------------------------------------

            resultat.Read();
            //resultat2.Read();

            tb_nom.Text = resultat["NOMFOU"].ToString();
            //tb_adresse.Text = resultat2["RUEFOU"].ToString();

            connect.Close();
        }
    }
}

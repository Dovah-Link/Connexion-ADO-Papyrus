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
    public partial class Exo3 : Form
    {
        public Exo3()
        {
            InitializeComponent();
        }
        private void Exo3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.; database=test; integrated security=true");
            con.Open();

            SqlCommand requete = new SqlCommand("select * from fournis", con);

            SqlDataReader resultat = requete.ExecuteReader();

            comboBox1.Items.Add("Tous");
            while (resultat.Read())
            {
                comboBox1.Items.Add(resultat["NOMFOU"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Size = new Size(379, 277);
            label2.Visible = true;
            listView1.Visible = true;
            listView1.Items.Clear();

            if (comboBox1.SelectedIndex != -1)
            {
                SqlConnection connect = new SqlConnection("server=.; database=test; integrated security=true");
                connect.Open();

                SqlDataReader resultat = null;

                if (comboBox1.SelectedIndex == 0)
                { 
                    SqlCommand requete = new SqlCommand(@"select * from FOURNIS join ENTCOM on ENTCOM.NUMFOU=FOURNIS.NUMFOU ", connect);
                    resultat = requete.ExecuteReader();
                }
                else
                {
                    SqlCommand requete = new SqlCommand(@"GetEntCom @NOMFOU", connect);
                    requete.Parameters.AddWithValue("@NOMFOU", comboBox1.SelectedItem);
                    resultat = requete.ExecuteReader();
                }

                while (resultat.Read())
                {
                    string d = Convert.ToDateTime(resultat["DATCOM"]).ToShortDateString();
                    ListViewItem lvi = new ListViewItem(resultat["NUMCOM"].ToString());
                    lvi.SubItems.Add(d);
                    lvi.SubItems.Add(resultat["OBSCOM"].ToString());

                    listView1.Items.Add(lvi);
                }
            }
        }
    }
}

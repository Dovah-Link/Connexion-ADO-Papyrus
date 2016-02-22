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
    public partial class Exo1Connexion : Form
    {

        public Exo1Connexion()
        {
            InitializeComponent();
        }
        SqlConnection connect;
        private void B_Connect_Click(object sender, EventArgs e)
        {
            string serveur = tb_serveur.Text;
            string baseDD = TB_BDD.Text;

            string str = String.Format("server={0}; database={1}; integrated security=true", serveur, baseDD);
            connect = new SqlConnection(str);
            connect.StateChange += Connect_StateChange;

            try
            {
                connect.Open();
                tb_erreur.Clear();  
            }
            catch(SqlException f)
            {
                tb_erreur.Text = f.Message;
            }
        }

        private void Connect_StateChange(object sender, StateChangeEventArgs e)
        {
            LBL_EtatConnect.Text = e.CurrentState.ToString();
        }

        private void B_deco_Click(object sender, EventArgs e)
        {
            if (connect != null)
            {
                connect.Close();
            }
        }
    }
}

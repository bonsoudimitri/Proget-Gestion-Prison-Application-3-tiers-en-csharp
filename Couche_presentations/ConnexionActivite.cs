using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using Couche_Metier;
using Couche_accesdonnee;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche_presentations
{
    public partial class ConnexionActivite : Form
    {
        public ConnexionActivite()
        {
            InitializeComponent();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkpassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkpassword.Checked == true)
            {
                chkpassword.Text = "Masquer Le Mot de Passe";
                txtPassswordU.PasswordChar = '\0';
            }
            else
            {
                txtPassswordU.PasswordChar = '*';
                chkpassword.Text = "Afficher Le Mot de passe";
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lbErreurU.Text = "";
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string user = null, pass = null, role = null;
            Utilisateurm ps = new Utilisateurm();
            UtilisateurDla psl = new UtilisateurDla();
            SqlDataReader lect;
            ps.nom = txtUserNameU.Text;
            ps.password = txtPassswordU.Text;
            SqlCommand cmd = new SqlCommand(@"select nom,password,role from user_tbl where nom='" + ps.nom + "'and password='" + ps.password + "'", psl.cn);
            psl.cn.Open();
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                user = lect.GetString(0);
                pass = lect.GetString(1);
                role = lect.GetString(2).ToString();
            }
            psl.cn.Close();
            // test= psl.testConnexion(ps);
            if (user == ps.nom && pass == ps.password && role=="Activite" || role=="Admin")
            {
                MessageBox.Show("Vous etes Autoriser a acceder a cette Page", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Acceuil ca = new Acceuil();
                ca.OuvrirFormulaire(new Activite());
                
            }
            else
            {
                lbErreurU.Text = "Vous n'avez pas le droit d'acceder a cette Page";
                txtPassswordU.Text = txtUserNameU.Text = "";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using Couche_accesdonnee;
using Couche_Metier;
using Couche_presentations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche_presentations
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Acceuil ca = new Acceuil();
            string user = null, pass = null, role = null;
          Utilisateurm ps = new Utilisateurm();
            UtilisateurDla psl = new UtilisateurDla();
            SqlDataReader lect;
            ps.nom = txtUserName.Text;
            ps.password = txtPasssword.Text;
            SqlCommand cmd = new SqlCommand(@"select nom,password,role from user_tbl where nom='" + ps.nom + "'and password='" + ps.password + "'", psl.cn);
            psl.cn.Open();
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                user = lect.GetString(0);
                pass = lect.GetString(1);
                role = lect.GetString(2);
            }
            psl.cn.Close();
            // test= psl.testConnexion(ps);
            if (user == ps.nom && pass == ps.password&& role=="Admin")
            {
                MessageBox.Show("Vous faite partie du Systeme ", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ca.Show();
                this.Hide();
            }
            else if (user == ps.nom && pass == ps.password && role == "Personnel")
            {
                ca.btnPersonnel.Anchor = AnchorStyles.Left;
                ca.btnPersonnel.Anchor = AnchorStyles.Right;
                ca.btnPersonnel.Anchor = AnchorStyles.Bottom; 
                ca.btnActivite.Visible = ca.btnCellule.Visible = ca.btnDelit.Visible = ca.btnPrison.Visible = ca.btnPrisonnier.Visible=ca.btnVisite.Visible= false;
                ca.Show();
                this.Hide();
            }
            else if (user == ps.nom && pass == ps.password && role == "Visite")
            {
                ca.btnCellule.Visible = ca.btnDelit.Visible = ca.btnPrison.Visible = ca.btnPersonnel.Visible=ca.btnActivite.Visible=false;
                ca.btnPrisonnier.Visible = false;
                ca.Show();
                this.Hide();
            }
            else if (user == ps.nom && pass == ps.password && role == "Detenue")
            {
                ca.btnPrison.Visible = ca.btnPersonnel.Visible = ca.btnActivite.Visible=ca.btnVisite.Visible = false;
               
                ca.Show();
                this.Hide();
            }
            else
            {
                lbErreur.Text = "Mot de Passe Ou Nom d'utilisateur Incorrect";
                txtPasssword.Text = txtUserName.Text = "";
            }
            //else if (user == ps.username && pass == ps.password && role == "produit")
            //{
            //    MessageBox.Show("Vous faite partie du Systeme ", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //    frmProduit fc = new frmProduit();
            //    fc.Show();
            //    this.Hide();

            //}
            //else if (user == ps.username && pass == ps.password && role == "client")
            //{
            //    MessageBox.Show("Vous faite partie du Systeme ", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //    frmClient fc = new frmClient();
            //    fc.Show();


            //}
            //else
            //{
            //    lberreur.Text = "Nom d'utilisateur ou Mot de passe incorrecte";
            //    txtPassword.Text = txtUsername.Text = "";
            //}
            
        }

        private void chkpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpassword.Checked == true)
            {
                chkpassword.Text = "Masquer Le Mot de Passe";
                txtPasssword.PasswordChar = '\0';
            }
            else
            {
                txtPasssword.PasswordChar = '*';
                chkpassword.Text = "Afficher Le Mot de passe";
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            lbErreur.Text = "";
        }

       
    }
}

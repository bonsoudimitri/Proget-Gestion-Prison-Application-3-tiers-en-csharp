using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche_presentations
{
    public partial class Acceuil : Form
    {
       public Form currentChildForm,nvform;
        public Acceuil()
        {
            InitializeComponent();
        }
        public void OuvrirFormulaire(Form childForm)
        {
            if (currentChildForm != null)
            {
                //ouvre seulement le formulaire
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(childForm);
            splitContainer1.Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            OuvrirFormulaire(new Presentation());
        }

        private void btnPrisonnier_Click(object sender, EventArgs e)
        {
            Prisonnier pn = new Prisonnier();
            OuvrirFormulaire(pn);
        }

        private void btnCellule_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new Cellule());
        }

        private void btnPrison_Click(object sender, EventArgs e)
        {


            OuvrirFormulaire(new Prison());
        }

        public void btnPersonnel_Click(object sender, EventArgs e)
        {
            //ConnexionPerso cp = new ConnexionPerso();
            //cp.Show();
           OuvrirFormulaire(new Utilisateur());
        }

        private void btnVisite_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new Visite());
        }

        private void btnActivite_Click(object sender, EventArgs e)
        {
            //ConnexionActivite ca = new ConnexionActivite();
            //ca.Show();
            OuvrirFormulaire(new Activite());
        }

        private void btnDelit_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new Delit());
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new Presentation());
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            Connexion ca = new Connexion();
            ca.Show();
            this.Hide();
        }

      
    }
}

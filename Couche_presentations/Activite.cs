using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Couche_Metier;
using Couche_accesdonnee;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche_presentations
{
    public partial class Activite : Form
    {
        VisteurDla vs = new VisteurDla();
        public Activite()
        {
            InitializeComponent();
            dgvActivite.Columns.Add("idAct", "Id");
            dgvActivite.Columns.Add("nomprisonnierAct", "Nom Prisonnier");
            dgvActivite.Columns.Add("lieuAct", "Lieu");
            dgvActivite.Columns.Add("dateAct", "Date");
            dgvActivite.Columns.Add("HeuredAct", "Heure Debut");
            dgvActivite.Columns.Add("heurefAct", "Heure Fin");
            dgvActivite.Columns.Add("descAct", "Description");
            RemplirCmb();
            RemplirDgv();
        }
        private void RemplirDgv()
        {
            dgvActivite.Rows.Clear();
            SqlDataReader lect;
            SqlCommand cmd = new SqlCommand(@"select * from activite order by id desc", vs.cn);
            vs.cn.Open();
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dgvActivite.Rows.Add(lect.GetValue(0), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4).ToString(), lect.GetValue(5).ToString(),
                    lect.GetValue(6).ToString());
            }
            vs.cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Activitesm ac = new Activitesm();
            ac.nom_prisionner = cmbNomdetenu.SelectedItem.ToString();
            ac.lieu = txtLieua.Text;
            ac.date = dateTimePickerActivites.Value.ToShortDateString();
            ac.heure_debut = dateTimePickerDebut.Value.ToShortTimeString();
            ac.heure_fin = dateTimePickerFin.Value.ToShortTimeString();
            ac.description = txtdesc.Text;
            ActiviteDla at = new ActiviteDla();
            at.Add(ac);
            RemplirDgv();
            Reset();
        }
        private void Reset()
        {
            txtdesc.Text = txtLieua.Text  = "";
            cmbNomdetenu.SelectedItem.Equals("");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Activitesm ac = new Activitesm();
            ac.id = Convert.ToInt32(dgvActivite.CurrentRow.Cells[0].Value);
            ac.nom_prisionner = cmbNomdetenu.SelectedItem.ToString();
            ac.lieu = txtLieua.Text;
            ac.date = dateTimePickerActivites.Value.ToShortDateString();
            ac.heure_debut = dateTimePickerDebut.Value.ToShortTimeString();
            ac.heure_fin = dateTimePickerFin.Value.ToShortTimeString();
            ac.description = txtdesc.Text;
            ActiviteDla at = new ActiviteDla();
            at.Update(ac);
            RemplirDgv();
            Reset();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Activitesm ac = new Activitesm();
            ac.id = Convert.ToInt32(dgvActivite.CurrentRow.Cells[0].Value);
            ActiviteDla at = new ActiviteDla();
            at.Delete(ac);
            RemplirDgv();
            Reset();
        }

        private void dgvActivite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActivite.CurrentCell.Selected)
            {
                   cmbNomdetenu.SelectedItem = dgvActivite.CurrentRow.Cells[1].Value.ToString();
                   txtLieua.Text  = dgvActivite.CurrentRow.Cells[2].Value.ToString();
                   dateTimePickerActivites.Value =Convert.ToDateTime( dgvActivite.CurrentRow.Cells[3].Value);
                   dateTimePickerDebut.Value= Convert.ToDateTime(dgvActivite.CurrentRow.Cells[4].Value);
                   dateTimePickerFin.Value = Convert.ToDateTime(dgvActivite.CurrentRow.Cells[5].Value);
                  txtdesc.Text=dgvActivite.CurrentRow.Cells[6].Value.ToString();
            }
        }
        private void RemplirCmb()
        {
            SqlDataReader lect;
            SqlCommand cmd = new SqlCommand(@" select nom from prisonnier order by nom asc", vs.cn);
            vs.cn.Open();
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
              
                 cmbNomdetenu.Items.Add(lect.GetValue(0).ToString());
            }
            vs.cn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvActivite.Rows.Clear();
                string nom = txtsearch.Text; ;
                string query = " select * from activite where nom_detenue='" + nom + "'";
                SqlCommand cmd = new SqlCommand(query, vs.cn);
                vs.cn.Open();
                SqlDataReader lect;
                lect = cmd.ExecuteReader();
                while (lect.Read())
                {

                    dgvActivite.Rows.Add(lect.GetValue(0), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString(), lect.GetValue(4).ToString(), lect.GetValue(5).ToString(),
                         lect.GetValue(6).ToString());

                }
                //if (lect.Read().Equals(0))
                //{
                //    MessageBox.Show("Ce Nom n'existe pas dans la base de donnee");
                //}
            }
            catch (Exception x)
            {
                MessageBox.Show("Ce Nom n'existe pas dans la base de donnee");
                
            }
         
            vs.cn.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            RemplirDgv();
        }
    }
}

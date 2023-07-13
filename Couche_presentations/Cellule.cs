using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Couche_Metier;
using Couche_accesdonnee;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couche_presentations
{
    public partial class Cellule : Form
    {
        CelluleDla ca = new CelluleDla();
        public Cellule()
        {
            InitializeComponent();
            //dgvCellule.Columns.Add("idcel", "Id");
            //dgvCellule.Columns.Add("nomcel", "Nom");
            //dgvCellule.Columns.Add("capacite", "Capacite");
            //dgvCellule.Columns.Add("nbprisocel", "Nombre Prisonnier");
            RemplirDgv();
        }
        private void RemplirDgv()
        {
            dgvCellule.Rows.Clear();
            SqlDataReader lect;
            SqlCommand cmd = new SqlCommand(@" select * from  cellule order by id desc",ca.cn);
            ca.cn.Open();
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dgvCellule.Rows.Add(lect.GetValue(0), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString());
            }
            ca.cn.Close();
        }
        private void Reset()
        {

        }
        private void btnAddcellule_Click(object sender, EventArgs e)
        {
            Cellulem ce = new Cellulem();
            ce.capacite = Convert.ToInt32(txtCapacite.Text);
            ce.nom_cellule = txtNomcel.Text;
            ce.nombre_prisonnier = Convert.ToInt32(txtNombre_cel.Text);
            CelluleDla ca = new CelluleDla();
            ca.Add(ce);
            RemplirDgv();
            Reset();

        }

        private void Cellule_Load(object sender, EventArgs e)
        {
           
        }

        private void dgvCellule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre_cel.Text = dgvCellule.CurrentRow.Cells["nbprisocel"].Value.ToString();
            txtCapacite.Text = dgvCellule.CurrentRow.Cells["Capacite"].Value.ToString();
            txtNomcel.Text = dgvCellule.CurrentRow.Cells["nomcel"].Value.ToString();
            
        }

        private void btnUpdatecel_Click(object sender, EventArgs e)
        {
            Cellulem ce = new Cellulem();
            ce.Matricule = Convert.ToInt32(dgvCellule.CurrentRow.Cells[0].Value);
            ce.capacite = Convert.ToInt32(txtCapacite.Text);
            ce.nom_cellule = txtNomcel.Text;
            ce.nombre_prisonnier = Convert.ToInt32(txtNombre_cel.Text);
            CelluleDla ca = new CelluleDla();
            ca.Update(ce);
            RemplirDgv();
            Reset();
        }

        private void btndeletecel_Click(object sender, EventArgs e)
        {
            Cellulem ce = new Cellulem();
            ce.Matricule = Convert.ToInt32(dgvCellule.CurrentRow.Cells[0].Value);
            CelluleDla ca = new CelluleDla();
            ca.Delete(ce);
            RemplirDgv();
            Reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCellule.Rows.Clear();
            string nom = txtsearch.Text; ;
            string query = " select * from cellule where nom_cellule='" + nom + "'";
            SqlCommand cmd = new SqlCommand(query, ca.cn);
            ca.cn.Open();
            SqlDataReader lect;
            lect = cmd.ExecuteReader();
            while (lect.Read())
            {
                dgvCellule.Rows.Add(lect.GetValue(0), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString());
                
            }
            ca.cn.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            RemplirDgv();
        }
    }
}

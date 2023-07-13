using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Couche_Metier;
using System.Threading.Tasks;

namespace Couche_accesdonnee
{
   public class CelluleDla
    {
     public  SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=Gestion_prison;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        public void Add(Cellulem ce)
        {
            try
            {
                string query = " insert into cellule (nom_cellule,capacite,nombre_prisonnier) values('" + ce.nom_cellule + "','" + ce.capacite + "','" + ce.nombre_prisonnier + "')";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout effectuer Avec Success", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        
            cn.Close();
        }
        public void Update(Cellulem ce)
        {
            try
            {
                string query = " update  cellule set nom_cellule='" + ce.nom_cellule + "',capacite='" + ce.capacite + "',nombre_prisonnier='" + ce.nombre_prisonnier+ "'  where Id='" + ce.Matricule + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Mise a jour effectuer Avec Success", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
               
            }
        
            cn.Close();

        }
        public void Delete(Cellulem ce)
        {
            try
            {
                string query = " delete  cellule where Id='" + ce.Matricule + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                #region MyRegion
                //cmd.Parameters.AddWithValue("@num_cellule", ce.num_cellule);
                //cmd.Parameters.AddWithValue("@capacite", ce.capacite);
                #endregion

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suppression effectuer Avec Success", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
           
            cn.Close();

        }
        #region
        public void Listall(Cellulem ce)
        {
            try
            {
                SqlDataReader lect;
                SqlCommand cmd = new SqlCommand("listallcellule", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                lect = cmd.ExecuteReader();
                while (lect.Read())
                {
                    ce.nom_cellule = lect.GetValue(1).ToString();
                    ce.capacite = Convert.ToInt32(lect.GetValue(2));
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
         
            cn.Close();
        }
        #endregion
        public void FindByid(string id)
        {
            try
            {
                string query = " select * from cellule where Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
          
            cn.Close();
        }
    }
}

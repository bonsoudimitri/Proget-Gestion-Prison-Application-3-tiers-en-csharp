using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Couche_Metier;
using System.Threading.Tasks;

namespace Couche_accesdonnee
{
  public   class PrisonDla
    {
       public  SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=Gestion_prison;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        public void Add(Prisonm ps)
        {
            try
            {
                string query = " insert into prison (nom,ville,quartier,contact) values('" + ps.nom + "','" + ps.ville + "','" + ps.quartier + "','" + ps.contact + "')";
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
        public void Update(Prisonm ps)
        {
            try
            {
                string query = " update  prison set nom='" + ps.nom + "',ville='" + ps.ville + "',quartier='" + ps.quartier + "',contact='" + ps.contact + "' where Id='" + ps.id + "'";
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
        public void Delete(Prisonm pd)
        {
            try
            {
                string query = " delete  prison where Id='"+pd.id+"'";
                SqlCommand cmd = new SqlCommand(query, cn);
                #region MyRegion
                //cmd.Parameters.AddWithValue("@nom", ps.nom);
                //cmd.Parameters.AddWithValue("@ville", ps.ville);
                //cmd.Parameters.AddWithValue("@quartier", ps.quartier);
                //cmd.Parameters.AddWithValue("@contact", ps.contact);
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
        public void Listall(Prisonm ps)
        {
            try
            {
                SqlDataReader lect;
                SqlCommand cmd = new SqlCommand("listallprison", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                #region MyRegion
                //cmd.Parameters.AddWithValue("@nom", ps.nom);
                //cmd.Parameters.AddWithValue("@ville", ps.ville);
                //cmd.Parameters.AddWithValue("@quartier", ps.quartier);
                //cmd.Parameters.AddWithValue("@contact", ps.contact);
                #endregion
                
                cn.Open();
                lect = cmd.ExecuteReader();
                while (lect.Read())
                {
                    ps.nom = lect.GetValue(1).ToString();
                    ps.ville = lect.GetValue(2).ToString();
                    ps.quartier = lect.GetValue(3).ToString();
                    ps.contact = lect.GetValue(4).ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
               
            }
          
            cn.Close();
        }
        #endregion
        public void FindByid( Prisonm id)
        {
            try
            {
                string query = " select * from prison where Id='" + id + "'";
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

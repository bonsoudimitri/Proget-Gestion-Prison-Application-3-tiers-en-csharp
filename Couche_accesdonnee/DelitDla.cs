using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Couche_Metier;
using System.Threading.Tasks;

namespace Couche_accesdonnee
{
  public   class DelitDla
    {
       public SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=Gestion_prison;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        public void Add(Delitm dl)
        {
            try
            {
                string query = " insert into delit (nom_prisonnier,date,libelle,sanction) values('" + dl.nom_prisonnier + "','" + dl.date_delit + "','" + dl.libelle + "','" + dl.sanction+ "')";
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
        public void Update(Delitm dl)
        {
            try
            {
                string query = " update  delit set nom_prisonnier='" + dl.nom_prisonnier + "',date='" + dl.date_delit + "',libelle='" + dl.libelle + "',sanction='" + dl.sanction + "' where Id='" + dl.id + "'";
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
        public void Delete(int id)
        {
            try
            {
                string query = " delete  delit where Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                #region MyRegion
                //cmd.Parameters.AddWithValue("@libelle", dl.libelle);
                //cmd.Parameters.AddWithValue("@date_delit", dl.date_delit);
                //cmd.Parameters.AddWithValue("@nom_prisonnier", dl.nom_prisonnier);
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
        public void ListeAll(Delitm dl)
        {
            try
            {
                SqlDataReader lect;
                SqlCommand cmd = new SqlCommand("listalldelit", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                #region MyRegion
                //cmd.Parameters.AddWithValue("@libelle", dl.libelle);
                //cmd.Parameters.AddWithValue("@date_delit", dl.date_delit);
                //cmd.Parameters.AddWithValue("@nom_prisonnier", dl.nom_prisonnier);
                #endregion

                cn.Open();
                lect = cmd.ExecuteReader();
                while (lect.Read())
                {
                    dl.nom_prisonnier = lect.GetValue(1).ToString();
                    dl.sanction = lect.GetValue(2).ToString();
                    dl.date_delit = lect.GetValue(3).ToString();
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
          
            cn.Close();

        }
        #endregion
        public void FindByid(int id)
        {
            try
            {
                string query = " select * from delit where Id='" + id + "'";
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

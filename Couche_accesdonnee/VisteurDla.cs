using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Couche_Metier;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Couche_accesdonnee
{
  public   class VisteurDla
    {
      public   SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=Gestion_prison;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        public void Add(Visiteurm vs)
        {
            try
            {
                string query = " insert into visite (num_cni,nom_visiteur,nom_prisonnier,tel,lien_parente,autorisation,date_visite,sexe) values('" + vs.Num_cni + "','" + vs.nom_visiteur + "','" + vs.nom_prisonnier + "',   '" + vs.Tel + "','" + vs.Lien_parente + "','" + vs.autorisation + "','" + vs.date_visit + "','" + vs.sexe + "')";
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
        public void Update(Visiteurm vs)
        {
            try
            {
                string query = " update visite set num_cni='" + vs.Num_cni + "',nom_visiteur='" + vs.nom_visiteur + "',nom_prisonnier='" + vs.nom_prisonnier + "',tel='" + vs.Tel + "',lien_parente='" + vs.Lien_parente + "',autorisation='" + vs.autorisation + "',date_visite='" + vs.date_visit + "',sexe='" + vs.sexe + "' where Id='" + vs.id + "'";
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
        public void Delete(Visiteurm vs)
        {
            try
            {

                string query = "delete  visite where Id='"+vs.id+"'";
                SqlCommand cmd = new SqlCommand(query, cn);
                #region MyRegion
                //cmd.Parameters.AddWithValue("@nom_visiteur", vs.nom_visiteur);
                //cmd.Parameters.AddWithValue("@nom_prisonnier", vs.nom_prisonnier);
                //cmd.Parameters.AddWithValue("@num_cni", vs.Num_cni);
                //cmd.Parameters.AddWithValue("@tel", vs.Tel);
                //cmd.Parameters.AddWithValue("@date_visit", vs.date_visit);
                //cmd.Parameters.AddWithValue("@heure_visit", vs.heure_visit);
                //cmd.Parameters.AddWithValue("@autorisation", vs.autorisation);
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
        public void Listall(Visiteurm vs)
        {
            try
            {
                SqlDataReader lect;
                string query = "select * from visite  order by Id asc";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                #region MyRegion
                //cmd.Parameters.AddWithValue("@nom_visiteur", vs.nom_visiteur);
                //cmd.Parameters.AddWithValue("@nom_prisonnier", vs.nom_prisonnier);
                //cmd.Parameters.AddWithValue("@num_cni", vs.Num_cni);
                //cmd.Parameters.AddWithValue("@tel", vs.Tel);
                //cmd.Parameters.AddWithValue("@date_visit", vs.date_visit);
                //cmd.Parameters.AddWithValue("@heure_visit", vs.heure_visit);
                //cmd.Parameters.AddWithValue("@autorisation", vs.autorisation);
                //cn.Open();
                //cmd.ExecuteNonQuery();
                //cn.Close();
                #endregion
                cn.Open();
                lect = cmd.ExecuteReader();
                while (lect.Read())
                {
                    vs.nom_prisonnier = lect["nom_prisonnier"].ToString();
                    vs.nom_visiteur = lect["nom_visiteur"].ToString();
                    vs.Num_cni = lect["num_cni"].ToString();
                    vs.Lien_parente = lect["contact"].ToString();
                    vs.date_visit =lect["date_visite"].ToString();
                    vs.autorisation = lect["autorisation"].ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
              
            }
            cn.Close();
          
        }
        public void FindByid(int id)
        {
            try
            {
                string query = "select * from visite  where Id='"+id+"'";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using Couche_Metier;
using System.Threading.Tasks;

namespace Couche_accesdonnee
{
   public  class ActiviteDla
    {
       public SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=Gestion_prison;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        public void Add(Activitesm act)
        {
            string query = " insert into activite (nom_detenue,lieu,date,heure_debut,heure_fin,description)values('" + act.nom_prisionner + "','" + act.lieu + "','" + act.date + "','" + act.heure_debut + "','" + act.heure_fin + "','" + act.description + "')";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Update(Activitesm act)
        {
            string query = " update activite set  nom_detenue='" + act.nom_prisionner + "',lieu='" + act.lieu + "',date='" + act.date + "',heure_debut='" + act.heure_debut + "',heure_fin='" + act.heure_fin + "',description='" + act.description + "' where Id='" + act.id + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Delete(Activitesm act)
        {
            string query = "delete activite where Id='" + act.id + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        #region
        public void Listall(Activitesm act)
        {
            SqlCommand cmd = new SqlCommand("listallactivite", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom_prisonnier", act.nom_prisionner);
            cmd.Parameters.AddWithValue("@date", act.date);
            cmd.Parameters.AddWithValue("@description", act.description);
            cmd.Parameters.AddWithValue("@heure_debut", act.heure_debut);
            cmd.Parameters.AddWithValue("@heure_fin", act.heure_fin);
            cmd.Parameters.AddWithValue("@lieu", act.lieu);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        #endregion

    }
}

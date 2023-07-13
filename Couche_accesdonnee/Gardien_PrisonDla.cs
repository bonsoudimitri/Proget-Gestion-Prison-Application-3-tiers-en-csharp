using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Couche_Metier;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Couche_accesdonnee
{
    class Gardien_PrisonDla
    {
       SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=Prisondb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

       public void ListAll(Prisonierm ce)
       {
           try
           {
               SqlDataReader lect;
               SqlCommand cmd = new SqlCommand("listallprisonnier", cn);
               #region parametersaddwithvalue
               //cmd.Parameters.AddWithValue("@nom", ce.nom);
               //cmd.Parameters.AddWithValue("@prenom", ce.prenom);
               //cmd.Parameters.AddWithValue("@sexe", ce.sexe);
               //cmd.Parameters.AddWithValue("@datenais", ce.datenais);
               //cmd.Parameters.AddWithValue("@date_incarcation", ce.date_integration);
               //cmd.Parameters.AddWithValue("@date_liberation", ce.date_liberation);
               //cmd.Parameters.AddWithValue("@etat_sante", ce.etat_sante);
               //cmd.Parameters.AddWithValue("@photo", ce.photo);
               #endregion
               cmd.CommandType = CommandType.StoredProcedure;
               cn.Open();
               lect = cmd.ExecuteReader();
               while (lect.Read())
               {
                   ce.nom = lect.GetString(1);
                   ce.prenom = lect.GetString(2);
                   ce.sexe = lect.GetString(3);
                   ce.datenais = lect.GetValue(4).ToString();
                   ce.date_integration = lect.GetValue(5).ToString();
                   ce.date_liberation = lect.GetValue(6).ToString();
                   ce.prison = lect.GetString(7);
                   ce.etat_sante = lect.GetString(8);
                   //ce.photo =lect.GetValue(9);
               }
           }
           catch (Exception x)
           {
               MessageBox.Show(x.Message);

           }

           cn.Close();
       }
       public void ListAllUser(Utilisateurm user)
       {
           try
           {
               SqlDataReader lect;
               SqlCommand cmd = new SqlCommand("listalluser", cn);
               cmd.CommandType = CommandType.StoredProcedure;
               #region MyRegion
               //cmd.Parameters.AddWithValue("@login", user.login);
               //cmd.Parameters.AddWithValue("@password", user.password);
               //cmd.Parameters.AddWithValue("@nom", user.nom);
               //cmd.Parameters.AddWithValue("@prenom", user.prenom);
               //cmd.Parameters.AddWithValue("@statut", user.statut);
               //cmd.Parameters.AddWithValue("@grade", user.grade);
               //cmd.Parameters.AddWithValue("@role", user.role);
               #endregion

               cn.Open();
               lect = cmd.ExecuteReader();
               while (lect.Read())
               {
                   user.login = lect.GetValue(1).ToString();
                   user.password = lect.GetValue(2).ToString();
                   user.nom = lect.GetValue(3).ToString();
                   user.prenom = lect.GetValue(4).ToString();
                   user.statut = lect.GetValue(5).ToString();
                   user.grade = lect.GetValue(6).ToString();
                   user.role = lect.GetValue(7).ToString();
               }
           }
           catch (Exception x)
           {
               MessageBox.Show(x.Message);

           }

           cn.Close();
       }
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
      
    }
}

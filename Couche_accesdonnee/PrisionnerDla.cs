using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Couche_Metier;
using System.Threading.Tasks;

namespace Couche_accesdonnee
{
   public class PrisonnierDla
    {
       public  SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=Gestion_prison;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        public void Add(Prisonierm ce)
        {
            try
            {
                string query = " insert into prisonnier (nom,prenom,date_naissance,date_entrer,date_liberation,etat_sante,photo,prison,sexe)values('" + ce.nom + "','" + ce.prenom + "','" + ce.datenais + "','" + ce.date_integration + "','" + ce.date_liberation + "','" + ce.etat_sante + "','" + ce.photo + "','" + ce.prison + "','" + ce.sexe + "')";
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
        public void Update(Prisonierm ce)
        {
            try
            {
                string query = " update prisonnier set  nom='" + ce.nom + "',sexe='" + ce.sexe + "',prenom='" + ce.prenom + "',date_entrer='" + ce.date_integration + "',date_naissance='" + ce.datenais + "',date_liberation='" + ce.date_liberation + "',etat_sante='" + ce.etat_sante + "',photo='" + ce.photo + "',prison='" + ce.prison + "' where Id='" + ce.id + "'";
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
                string query = "delete prisonnier where Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                #region parameters
                //cmd.Parameters.AddWithValue("@prenom", ce.prenom);
                //cmd.Parameters.AddWithValue("@sexe", ce.sexe);
                //cmd.Parameters.AddWithValue("@datenais", ce.datenais);
                //cmd.Parameters.AddWithValue("@date_incarcation", ce.date_integration);
                //cmd.Parameters.AddWithValue("@date_liberation", ce.date_liberation);
                //cmd.Parameters.AddWithValue("@etat_sante", ce.etat_sante);
                //cmd.Parameters.AddWithValue("@photo", ce.photo);
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
                   // ce.photo = (lect.GetValue(9));
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
               
            }
          
            cn.Close();
        }
        #endregion
        public void Transfert(Prisonierm ce)
        {
            try
            {
                if (MessageBox.Show("êtes  Vous sûr de vouloir Transferer Le Prisonnier '" + ce.nom + "'  Vers La Prison '" + ce.prison + "'", "Transfert", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    string query = "update prisonnier set prison='" + ce.prison + "' where Id='" + ce.id + "'";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transfert  effectuer Avec Success", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transfert  Annuler", "Transfert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
          
            cn.Close();

        }
        public void Findbyid(int id)
        {
            try
            {
                string query = " select * from prisonnier where Id='" + id + "'";
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

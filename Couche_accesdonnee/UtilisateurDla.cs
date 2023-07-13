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
   public  class UtilisateurDla
    {
       public  SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=Gestion_prison;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        public void AddUser(Utilisateurm user)
        {
            try
            {
                string query = " insert into user_tbl (nom,prenom,date_naissance,statut,grade,role,password)values('" + user.nom + "','" + user.prenom + "','" + user.date_naissance + "','" + user.statut + "','" + user.grade + "','" + user.role + "','" + user.password + "')";
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
       
        public void DeleteUser(string id)
        {
            try
            {
                if (MessageBox.Show(" Est Vous Sur de vouloir Supprimer", "supprimmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "delete  user_tbl where Id='" + id + "'";
                    SqlCommand cmd = new SqlCommand(query, cn);
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
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression effectuer Avec Success", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                
            }
           
            cn.Close();
        }
        public void UpdateUser(Utilisateurm user)
        {
            try
            {
                string query = " update user_tbl set  nom='" + user.nom + "',prenom='" + user.prenom + "',date_naissance='" + user.date_naissance + "',statut='" + user.statut + "',grade='" + user.grade + "',role='" + user.role + "',password='" + user.password + "' where Id='" + user.id + "'";
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
        public Utilisateurm ListAllUser()
        {
            Utilisateurm user=new Utilisateurm();
            try
            {
                SqlDataReader lect;
                string query = "select * from user_tbl where order by nom asc";
                SqlCommand cmd = new SqlCommand(query, cn);
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
                    user.id =Convert.ToInt32( lect["Id"]);
                    user.password = lect["password"].ToString();
                    user.nom = lect["nom"].ToString();
                    user.prenom = lect["prenom"].ToString();
                    user.statut = lect["statut"].ToString();
                    user.grade = lect["grade"].ToString();
                    user.role = lect["role"].ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
              
            }
           
            cn.Close();
            return user;
        }
        public void FindByid(string id)
        {
            string query = "select * from user_tbl where Id='"+id+"'";
            SqlCommand cmd = new SqlCommand(query, cn);
            try
            {
               
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

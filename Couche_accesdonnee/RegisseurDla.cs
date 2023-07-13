using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Couche_Metier;
using System.Threading.Tasks;

namespace Couche_accesdonnee
{
    class RegisseurDla
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=Prisondb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        public object  NbPrisonnier()
        {
           object nb=null;
            try
            {
                SqlCommand cmd = new SqlCommand("nbprisonnier", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                nb = cmd.ExecuteNonQuery();

            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            return nb;
        }
        public object NbDelit()
        {
           object nb=null;

            try
            {
                SqlCommand cmd = new SqlCommand("nbdelit", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                nb = cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            return nb;
        }
        public object  NbActiviter()
        {
           object nb=null;
            try
            {
                SqlCommand cmd = new SqlCommand("nbactivite", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                nb = cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            return nb;
        }
        public object NbVisite()
        {
           object nb=null;
            try
            {
                SqlCommand cmd = new SqlCommand("nbvisiteur", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                nb = cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            return nb;
        }
        public object NbPersonnel()
        {
           object nb=null;
            try
            {
                SqlCommand cmd = new SqlCommand("nbuser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                nb = cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            return nb;
        }
        public object NbCellule()
        {
            object nb=null;
            try
            {
                SqlCommand cmd = new SqlCommand("nbcellule", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                nb = cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            return nb;
        }
        public object  NbPrison()
        {
           object nb=null;
            try
            {
                SqlCommand cmd = new SqlCommand("nbprison", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                nb = cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            return nb;
        }
    }
}

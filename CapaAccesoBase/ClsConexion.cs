using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class ClsConexion
    {
        private MySqlConnection oCN = new MySqlConnection("server=localhost;user id=root;database=cinemaproyectdb");
        
        private bool AbrirConexion()
        {
            try
            {
                oCN.Open();
                return true;
            }
            catch(Exception)
            {
                return false;    
            }
            
        }
        private bool CerrarConexion()
        {
            try
            {
                if(oCN.State == ConnectionState.Closed)
                {
                    return true;
                }
                oCN.Close();
                return true;
            }
            catch (Exception)
            {  
                throw;
            }
            finally
            {
                oCN.Close();
            }
        }

        public DataTable ejecutar(String txtSelect)
        {
            MySqlCommand cSelect = new MySqlCommand();
            DataTable oDT = new DataTable();
            MySqlDataAdapter oMYSQLDA = new MySqlDataAdapter(cSelect);
            try
            {
                cSelect.CommandText = txtSelect;
                cSelect.Connection = oCN;
            }
            catch (Exception)
            {
                throw;
            }
            if (AbrirConexion())
            {
                oMYSQLDA.Fill(oDT);
            }
            CerrarConexion();

            return oDT;
        }
        public bool ejecutarInsert (String txtInsert)
            {
            MySqlCommand cInsert = new MySqlCommand(txtInsert);
            try
            {
                cInsert.Connection = oCN;
                cInsert.CommandType = CommandType.Text;
                if (AbrirConexion())
                {
                    cInsert.ExecuteNonQuery();
                }
                CerrarConexion();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

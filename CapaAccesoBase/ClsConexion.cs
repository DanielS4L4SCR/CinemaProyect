using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaAccesoBase
{
    public class ClsConexion
    {
        private MySqlConnection oCN = new MySqlConnection("server=127.0.0.1:3307,port=3307;database=cinemaproyectdb;Uid=root;pwd=salitas7781");
        
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
        
    }
}

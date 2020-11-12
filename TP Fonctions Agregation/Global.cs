using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Fonctions_Agregation
{
    class Global
    {

        static public String cs = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|MaBase.accdb";

        static public OleDbConnection seConnecter(String strCN)
        {
            //on va créer un objet de connexion objCN
            OleDbConnection objCN = new OleDbConnection();
            try
            {
                // Définir la chaîne de connexion
                objCN.ConnectionString = strCN;
                // si la connexion est fermée, on l'ouvre avec la méthode open
                if (objCN.State == System.Data.ConnectionState.Closed)
                    objCN.Open();

            }
            catch (Exception)
            {

                throw;
            }
            return objCN;
        }

        static public void seDeconnecter(OleDbConnection objCN)
        {
            try
            {
                if (objCN.State == System.Data.ConnectionState.Open)
                    objCN.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        static public Object ExecuterOleDBScalaire(String strSQL, OleDbConnection objCN)
        {
            Object obj = new object();
            OleDbCommand objCom = new OleDbCommand(strSQL, objCN);
            try
            {
                obj = objCom.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            return obj;
        }

      

    }
}

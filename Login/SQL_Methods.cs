using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class SQL_Methods
    {

        #region Variables de Clase
        public static bool DBConnectStatus = false;
        #endregion


        static public MySqlConnection IniciarConnection()
        {
        MySqlConnection myConnection;

        string ConectionQuery = "Server=192.168.0.101;User id=eric; Database=librecea; Password=eric";

        myConnection = new MySqlConnection(ConectionQuery);
        try
            {
                myConnection.Open();
                DBConnectStatus = true;
                return myConnection;
            }
        catch (Exception e)
            {
                DBConnectStatus = false;
                MessageBox.Show(ConectionQuery);
                MessageBox.Show(e.ToString());
                return null;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace Login.Data
{
    internal class Connection
    {

        public static String server = "127.0.0.1";
        public static String dataBase = "Login";
        public static String user = "root";
        public static String psw = "";

        public static MySqlConnection connMaster = new MySqlConnection();

        
        public static void openConnection()
        {
            string connectionString = $"server={server};database={dataBase};user={user},password={psw}";
            
            connMaster = new MySqlConnection(connectionString) ;

            connMaster.Open();

            if (connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexion Establecida");
            }

            else 
            {
                MessageBox.Show("No se ha conectado");
            }
        }

        public void closeConnection() 
        {
             
        }
    }
}

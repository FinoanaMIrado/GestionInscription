using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionInscription
{
    internal class liaisonBD
    {
        private string connectionString;
        public liaisonBD()
        {
            connectionString = "server=localhost;database=gestion_inscriptions;user=root;password=;";
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public MySqlConnection OpenConnection()
        {
            MySqlConnection connection = GetConnection();
            try
            {
                //MessageBox.Show("Connection successful!");
                connection.Open();
                return connection;
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
                return null;
            }

        }
        public void CloseConnection(MySqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

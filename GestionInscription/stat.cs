using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionInscription
{
    public partial class stat : UserControl
    {
        public stat()
        {
            InitializeComponent();
            stat_Load();
        }
        liaisonBD DB = new liaisonBD();
        private void stat_Load()
        {
            var conn = DB.OpenConnection();
            int total_classe = 0;
            int total_eleve = 0;
            int total_inscription = 0;
            int total_paiement = 0;

            try
            {
                string countClass = "SELECT COUNT(CodeClasse)  FROM classe";
                string countEleve = "SELECT COUNT(Matricule)  FROM eleve";
                string countInscription = "SELECT COUNT(NumeroInscription)  FROM inscription";
                string countPaiement = "SELECT COUNT(NumPaiement)  FROM paiement";

                MySqlCommand nbclass= new MySqlCommand(countClass, conn);
                MySqlCommand nbeleve = new MySqlCommand(countEleve, conn);
                MySqlCommand nbinscription = new MySqlCommand(countInscription, conn);
                MySqlCommand nbpaiement =new MySqlCommand(countPaiement, conn);

                total_classe =Convert.ToInt32(nbclass.ExecuteScalar());
                total_eleve = Convert.ToInt32(nbeleve.ExecuteScalar());
                total_inscription = Convert.ToInt32(nbinscription.ExecuteScalar());
                total_paiement = Convert.ToInt32(nbpaiement.ExecuteScalar());

                nbttcl.Text = total_classe.ToString();
                nb_el.Text = total_eleve.ToString();
                nb_ins.Text = total_inscription.ToString();
                nb_p.Text = total_paiement.ToString();

            }
            catch (MySqlException errer)
            {

                MessageBox.Show("Erreur : "+ errer.Message);
            }
        }
    }
}

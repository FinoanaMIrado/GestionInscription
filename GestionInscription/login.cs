using MySql.Data.MySqlClient;

namespace GestionInscription
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        liaisonBD DB = new liaisonBD();

        public bool isOk(string nomUser, string mdp)
        {
            var conn = DB.OpenConnection();
            if (conn != null)
            {
                string loginy = "SELECT COUNT(*) FROM utilisateurs WHERE nom_utilisateur = @nom AND mot_de_passe =@mdp";

                MySqlCommand cmd = new MySqlCommand(loginy, conn);
                cmd.Parameters.AddWithValue("@nom", nomUser);
                cmd.Parameters.AddWithValue("@mdp", mdp);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                DB.CloseConnection(conn);
                return count > 0;
            }
            return false;
            //MessageBox.Show("Nom d'utilisateur ou mot de passe incorrectes.");


        }


        private void btn_conct_Click(object sender, EventArgs e)
        {
            var noms = nom.Text.Trim();
            var mdps = mdp.Text.Trim();

            bool isValid = isOk(noms, mdps);
            if (isValid)
            {
                //MessageBox.Show("Connexion ok");
                principale a = new principale();
                //stat a=new stat();
                a.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrecte aux niv du mdp ou nomuser");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

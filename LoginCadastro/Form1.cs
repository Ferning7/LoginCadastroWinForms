using MySql.Data.MySqlClient;

namespace LoginCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* try
             {

                 string usuario = txtUsuario.Text;
                 string senha = txtSenha.Text;



                 if (usuario != "" && senha != "")
                 {
                     string conexaoBanco = "Server=localHost; Database=sistemaLogin; Uid=root; pwd=''";
                     MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                     conexao.Open();

                     string consultaUsuario = "SELECT * FROM usuarios WHERE usuario = @usuario and senha = @senha ";
                     MySqlCommand comandoSQL = new MySqlCommand(consultaUsuario, conexao);

                     comandoSQL.Parameters.AddWithValue("@usuario", usuario);
                     comandoSQL.Parameters.AddWithValue("@senha", senha);

                     int registro = Convert.ToInt32(comandoSQL.ExecuteScalar());

                     if (registro > 0)
                     {
                         MessageBox.Show("Login realizado com sucesso!");
                     }
                     else
                     {
                         MessageBox.Show("Usuário ou Senha inválidos!");
                     }

                     conexao.Close();

                 }
                 else
                 {
                     MessageBox.Show("Usuário ou Senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cadastro telaCadastro = new cadastro();
            telaCadastro.Show();
            this.Hide();
        }
    }
}

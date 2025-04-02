using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCadastro
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            try
            {

                string usuarioCadastro = txtUserCadastro.Text;
                string senhaCadastro = txtSenhaCadastro.Text;



                if (usuarioCadastro != "" && senhaCadastro != "")
                {
                    string conexaoBanco = "Server=localHost; Database=sistemaLogin; Uid=root; pwd=''";
                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                    conexao.Open();

                    string consultaUsuario = "SELECT * FROM usuarios WHERE usuario = @usuario and senha = @senha";
                    MySqlCommand comandoSQL = new MySqlCommand(consultaUsuario, conexao);



                    comandoSQL.Parameters.AddWithValue("@usuario", usuarioCadastro);
                    comandoSQL.Parameters.AddWithValue("@senha", senhaCadastro);



                    int registro = Convert.ToInt32(comandoSQL.ExecuteScalar());



                    if (registro > 0)
                    {
                        MessageBox.Show("Esse usuário já existe!");
                    }
                    else
                    {

                        string cadastroSQL = "INSERT INTO usuarios (usuario, senha) values (@usuario, @senha)";
                        MySqlCommand comandoSQLCadastro = new MySqlCommand(cadastroSQL, conexao);

                        comandoSQLCadastro.Parameters.AddWithValue("@usuario", usuarioCadastro);
                        comandoSQLCadastro.Parameters.AddWithValue("@senha", senhaCadastro);

                        int insert = Convert.ToInt32(comandoSQLCadastro.ExecuteScalar());

                        string consultaCadastro = "select * from usuarios where usuario = @usuario and senha = @senha";
                        MySqlCommand comandoSQLConsultaCadastro = new MySqlCommand(consultaCadastro, conexao);

                        comandoSQLConsultaCadastro.Parameters.AddWithValue("@usuario", usuarioCadastro);
                        comandoSQLConsultaCadastro.Parameters.AddWithValue("@senha", senhaCadastro);

                        int ConsRegistroCadastro = Convert.ToInt32(comandoSQLConsultaCadastro.ExecuteScalar());

                        if (ConsRegistroCadastro > 0)
                        {
                            MessageBox.Show("Cadastrado com sucesso!");
                            Form1 telaLogin = new Form1();

                            telaLogin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cadastrar o usuário!");
                        }

                    }

                    conexao.Close();

                }
                else
                {
                    MessageBox.Show("Os campo não pode estar vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtUserCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaCadastro_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}

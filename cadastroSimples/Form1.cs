using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace cadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ValidarNome();
            ValidarEmail();
            ValidarIdade();
            ValidarSenha();
            ValidarConfirmarSenha();
            ValidarCheckBox();

            if(ValidarNome && ValidarEmail && ValidarIdade && ValidarSenha && ValidarConfirmarSenha && ValidarCheckBox)
            {
                MessageBox.Show("Sucesso, todos os campos foram preenchidos corretamente", "Sucesso");
            }
            else
            {
                MessageBox.Show("Um ou mais campos foram preenchidos incorretamente ", "Sucesso");
            }
        }
        private bool ValidarNome()
        {
            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                errorProvider1.SetError(txtNomeCompleto, "Digite o seu nome completo");
                return false;

            }
                
            if (txtNomeCompleto.Text.Length <= 3)
            {
                errorProvider1.SetError(txtNomeCompleto, "O nome deve ter mais de 3 caracteres");
                return false;

            }
            errorProvider1.SetError(txtNomeCompleto, "");
            return true;
        }
        private bool ValidarEmail()
        {
            if (txtEmail.Text == "" || txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Inv�lido, digite o seu email correto","Erro");
                return false;
            }
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Inv�lido, aus�ncia de @ ", "Erro");
                return false;
            }
            int arroba = txtEmail.Text.IndexOf("@");
            if (arroba > 0)
            {
                string restanteDoEmail = txtEmail.Text.Substring(arroba + 1);

                if (restanteDoEmail.Length > 1 &&
                restanteDoEmail[0] != '.' &&
                !restanteDoEmail.Contains("@") &&
                restanteDoEmail.Contains("."))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;

        }
        private bool ValidarIdade()
        {
            if (string.IsNullOrEmpty(txtIdade.Text))
            {
                MessageBox.Show("Inv�lido, digite a idade v�lida", "Erro");
                return false;
            }
            int idade;
            idade = int.Parse(txtIdade.Text);
            if (idade < 18 || idade > 100)
            {
                MessageBox.Show("Inv�lido, Precisa ser de maior de idade", "Erro");
                return false;
            }
            return true;
        }
        private bool ValidarSenha()
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Inv�lido, digite uma senha", "Erro");
                return false;
            }
            if (txtSenha.Text.Length < 6)
            {
                return false;
            }
            return true;

            
        }
        private bool ValidarConfirmarSenha()
        {
            if (string.IsNullOrEmpty(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Inv�lido, digite uma senha", "Erro");
                return false;
            }
            if(txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("Inv�lido, as senhas n�o s�o iguais", "Erro");
                return false;
            }
            return true;
        }
        private void ValidarCheckBox()
        {
            if (!ckTermosUso.Checked)
            {
                MessageBox.Show("Obrigat�rio validar os termos de servi�o", "Erro");
            }
                return;
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            txtIdade.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            //ckTermosUso.();
        }
    }
}

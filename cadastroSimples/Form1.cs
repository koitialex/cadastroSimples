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
           // errorProvider.BlinkRate = 0;
        }
        //private ErrorProvider errorProvider = new ErrorProvider();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ValidarNome();
            ValidarEmail();
            ValidarIdade();
            ValidarSenha();
            ValidarConfirmarSenha();
            ValidarCheckBox();
           

            if (ValidarNome() && ValidarEmail() && ValidarIdade() && ValidarSenha() && ValidarConfirmarSenha() && ValidarCheckBox())
            {
                MessageBox.Show("Sucesso, todos os campos foram preenchidos corretamente", "Sucesso");
            }
            else
            {
                MessageBox.Show("Um ou mais campos foram preenchidos incorretamente ", "Erro");
            }
        }
        private bool ValidarNome()
        {
            if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                epNomeCompleto.SetError(txtNomeCompleto, "Digite o seu nome completo");
                return false;

            }
                
            if (txtNomeCompleto.Text.Length <= 3)
            {
                epNomeCompleto.SetError(txtNomeCompleto, "O nome deve ter mais de 3 caracteres");
                return false;

            }
            epNomeCompleto.SetError(txtNomeCompleto, "");
            return true;
        }
        private bool ValidarEmail()
        {
            if (txtEmail.Text == "" || txtEmail.Text.Trim() == "")
            {
                epEmail.SetError(txtEmail, "Inválido, digite o seu email correto");
                return false;
            }
            if (!txtEmail.Text.Contains("@"))
            {
                epEmail.SetError(txtEmail, "Inválido, ausência de @ ");
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
                    epEmail.SetError(txtEmail, "Formato de email inválido.");
                    return false;
                }

            }
            epEmail.SetError(txtEmail, "Formato de email inválido.");
            return false;

        }
        private bool ValidarIdade()
        {
            if (string.IsNullOrEmpty(txtIdade.Text))
            {
                epIdade.SetError(txtIdade,"Inválido, digite a idade válida");
                return false;
            }
            int idade;
            idade = int.Parse(txtIdade.Text);
            if (idade < 18 || idade > 100)
            {
                epIdade.SetError(txtIdade, "Inválido, Precisa ser de maior de idade");
                return false;
            }
            epIdade.SetError(txtIdade, "");
            return true;
        }
        //private bool Validarcpf(string cpf)
        //{
        //    cpf = cpf.Remove(3, 1);
        //    cpf = cpf.Remove(6, 1);
        //    cpf = cpf.Remove(9, 1);
        //    if (cpf == null || cpf.Trim() == "" || !cpf.All(char.IsDigit) || cpf.Length != 11)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //    return true;
        //}
        //private bool ValidarTelefone(string telefone)
        //{
        //     telefone = mtbTelefone.Text.Replace("(", "");
        //    return true
        //}
        private bool ValidarSenha()
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                epSenha.SetError(txtSenha,"Inválido, digite uma senha" );
                return false;
            }
            if (txtSenha.Text.Length < 6)
            {
                epSenha.SetError(txtSenha, "Inválido, senha requer no mínimo 6 caracteres");
                return false;
            }
            epSenha.SetError(txtSenha, "");
            return true;

            
        }
        private bool ValidarConfirmarSenha()
        {
            if (string.IsNullOrEmpty(txtConfirmarSenha.Text))
            {
                EpConfirmarSenha.SetError(txtConfirmarSenha,"Inválido, digite uma senha");
                return false;
            }
            if(txtSenha.Text != txtConfirmarSenha.Text)
            {
                EpConfirmarSenha.SetError(txtConfirmarSenha, "Inválido, as senhas não são iguais");
                return false;
            }
            EpConfirmarSenha.SetError(txtConfirmarSenha, "");
            return true;
        }
        private bool ValidarCheckBox()
        {
            if (!ckTermosUso.Checked)
            {
               epTermos.SetError(ckTermosUso,"Obrigatório validar os termos de serviço" );
                return false;
            }
            epTermos.SetError(ckTermosUso, "");
            return true;
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            txtIdade.Clear();
            //mtbCpf.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            ckTermosUso.Checked = false;
        }
    }
}

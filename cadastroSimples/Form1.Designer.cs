namespace cadastroSimples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnEnviar = new Button();
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblIdade = new Label();
            txtIdade = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblConfirmarSenha = new Label();
            txtConfirmarSenha = new TextBox();
            ckTermosUso = new CheckBox();
            Limpar = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(233, 397);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(234, 42);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 1;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(237, 67);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(228, 23);
            txtNomeCompleto.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(241, 96);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(237, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(233, 157);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 5;
            lblIdade.Text = "Idade";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(237, 186);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(125, 23);
            txtIdade.TabIndex = 6;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(237, 221);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(237, 239);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(228, 23);
            txtSenha.TabIndex = 8;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(233, 276);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(95, 15);
            lblConfirmarSenha.TabIndex = 9;
            lblConfirmarSenha.Text = "Confirmar senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(233, 302);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(228, 23);
            txtConfirmarSenha.TabIndex = 10;
            // 
            // ckTermosUso
            // 
            ckTermosUso.AutoSize = true;
            ckTermosUso.Location = new Point(233, 340);
            ckTermosUso.Name = "ckTermosUso";
            ckTermosUso.Size = new Size(102, 19);
            ckTermosUso.TabIndex = 11;
            ckTermosUso.Text = "Termos de uso";
            ckTermosUso.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(374, 399);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(75, 23);
            Limpar.TabIndex = 12;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            Limpar.Click += Limpar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Limpar);
            Controls.Add(ckTermosUso);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtIdade);
            Controls.Add(lblIdade);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            Controls.Add(btnEnviar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblIdade;
        private TextBox txtIdade;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblConfirmarSenha;
        private TextBox txtConfirmarSenha;
        private CheckBox ckTermosUso;
        private Button Limpar;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
    }
}

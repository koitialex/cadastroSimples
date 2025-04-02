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
            epNomeCompleto = new ErrorProvider(components);
            epEmail = new ErrorProvider(components);
            epIdade = new ErrorProvider(components);
            epSenha = new ErrorProvider(components);
            EpConfirmarSenha = new ErrorProvider(components);
            epTermos = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epNomeCompleto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epIdade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpConfirmarSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epTermos).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(145, 368);
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
            lblNomeCompleto.Location = new Point(145, 72);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 1;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(145, 100);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(228, 23);
            txtNomeCompleto.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(145, 126);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(145, 170);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 5;
            lblIdade.Text = "Idade";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(145, 188);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(110, 23);
            txtIdade.TabIndex = 6;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(145, 221);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(145, 239);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(228, 23);
            txtSenha.TabIndex = 8;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(145, 273);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(95, 15);
            lblConfirmarSenha.TabIndex = 9;
            lblConfirmarSenha.Text = "Confirmar senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(145, 291);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(228, 23);
            txtConfirmarSenha.TabIndex = 10;
            // 
            // ckTermosUso
            // 
            ckTermosUso.AutoSize = true;
            ckTermosUso.Location = new Point(145, 332);
            ckTermosUso.Name = "ckTermosUso";
            ckTermosUso.Size = new Size(137, 19);
            ckTermosUso.TabIndex = 11;
            ckTermosUso.Text = "Concordo com tudo ";
            ckTermosUso.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(298, 368);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(75, 23);
            Limpar.TabIndex = 12;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            Limpar.Click += Limpar_Click;
            // 
            // epNomeCompleto
            // 
            epNomeCompleto.ContainerControl = this;
            // 
            // epEmail
            // 
            epEmail.ContainerControl = this;
            // 
            // epIdade
            // 
            epIdade.ContainerControl = this;
            // 
            // epSenha
            // 
            epSenha.ContainerControl = this;
            // 
            // EpConfirmarSenha
            // 
            EpConfirmarSenha.ContainerControl = this;
            // 
            // epTermos
            // 
            epTermos.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 450);
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
            ((System.ComponentModel.ISupportInitialize)epNomeCompleto).EndInit();
            ((System.ComponentModel.ISupportInitialize)epEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)epIdade).EndInit();
            ((System.ComponentModel.ISupportInitialize)epSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpConfirmarSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)epTermos).EndInit();
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
        private ErrorProvider epNomeCompleto;
        private ErrorProvider epEmail;
        private ErrorProvider epIdade;
        private ErrorProvider epSenha;
        private ErrorProvider EpConfirmarSenha;
        private ErrorProvider epTermos;
    }
}

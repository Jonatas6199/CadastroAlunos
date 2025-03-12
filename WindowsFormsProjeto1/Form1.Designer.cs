namespace WindowsFormsProjeto1
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
            txtNome = new TextBox();
            lblNome = new Label();
            txtCPF = new MaskedTextBox();
            CPF = new Label();
            txtNumeroMatricula = new TextBox();
            label1 = new Label();
            txtCelular = new MaskedTextBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            txtNomeDaMae = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(399, 23);
            txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(18, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(18, 95);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(76, 23);
            txtCPF.TabIndex = 5;
            // 
            // CPF
            // 
            CPF.AutoSize = true;
            CPF.Location = new Point(18, 77);
            CPF.Name = "CPF";
            CPF.Size = new Size(28, 15);
            CPF.TabIndex = 6;
            CPF.Text = "CPF";
            // 
            // txtNumeroMatricula
            // 
            txtNumeroMatricula.Location = new Point(122, 95);
            txtNumeroMatricula.Name = "txtNumeroMatricula";
            txtNumeroMatricula.Size = new Size(119, 23);
            txtNumeroMatricula.TabIndex = 7;
            txtNumeroMatricula.TextChanged += txtNumeroMatricula_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 77);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 8;
            label1.Text = "Matrícula";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(273, 95);
            txtCelular.Mask = "(00)00000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(100, 23);
            txtCelular.TabIndex = 9;
            txtCelular.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 77);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Telefone";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(18, 159);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 11;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 141);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 12;
            label3.Text = "Data de Nascimento";
            // 
            // txtNomeDaMae
            // 
            txtNomeDaMae.Location = new Point(150, 159);
            txtNomeDaMae.Name = "txtNomeDaMae";
            txtNomeDaMae.Size = new Size(223, 23);
            txtNomeDaMae.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 141);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 14;
            label4.Text = "Nome da Mãe";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(18, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 23);
            txtEmail.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 205);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 16;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtNomeDaMae);
            Controls.Add(label3);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(txtCelular);
            Controls.Add(label1);
            Controls.Add(txtNumeroMatricula);
            Controls.Add(CPF);
            Controls.Add(txtCPF);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private MaskedTextBox txtCPF;
        private Label CPF;
        private TextBox txtNumeroMatricula;
        private Label label1;
        private MaskedTextBox txtCelular;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private TextBox txtNomeDaMae;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
    }
}

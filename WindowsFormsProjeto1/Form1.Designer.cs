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
            txtCelular = new MaskedTextBox();
            label2 = new Label();
            txtDataNascimento = new MaskedTextBox();
            label3 = new Label();
            txtNomeDaMae = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtLogradouro = new TextBox();
            label6 = new Label();
            txtNumero = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtCep = new MaskedTextBox();
            txtBairro = new TextBox();
            label9 = new Label();
            txtCidade = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtEstado = new TextBox();
            txtPaís = new TextBox();
            label12 = new Label();
            btnSalvar = new Button();
            txtComplemento = new TextBox();
            label13 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label14 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lvRegistros = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(399, 23);
            txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 17);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(443, 35);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(98, 23);
            txtCPF.TabIndex = 5;
            // 
            // CPF
            // 
            CPF.AutoSize = true;
            CPF.Location = new Point(443, 17);
            CPF.Name = "CPF";
            CPF.Size = new Size(28, 15);
            CPF.TabIndex = 6;
            CPF.Text = "CPF";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(399, 91);
            txtCelular.Mask = "(00)00000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(100, 23);
            txtCelular.TabIndex = 9;
            txtCelular.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 73);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Telefone";
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(20, 91);
            txtDataNascimento.Mask = "00/00/0000";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(100, 23);
            txtDataNascimento.TabIndex = 11;
            txtDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 73);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 12;
            label3.Text = "Data de Nascimento";
            // 
            // txtNomeDaMae
            // 
            txtNomeDaMae.Location = new Point(152, 91);
            txtNomeDaMae.Name = "txtNomeDaMae";
            txtNomeDaMae.Size = new Size(223, 23);
            txtNomeDaMae.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 73);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 14;
            label4.Text = "Nome da Mãe";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 23);
            txtEmail.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 131);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(9, 48);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(175, 23);
            txtLogradouro.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 30);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 18;
            label6.Text = "Logradouro";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(199, 48);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(95, 23);
            txtNumero.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 30);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 20;
            label7.Text = "Numero";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(319, 30);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 22;
            label8.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(319, 48);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 23;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(434, 48);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(95, 23);
            txtBairro.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(434, 30);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 25;
            label9.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(9, 119);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(131, 23);
            txtCidade.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 101);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 27;
            label10.Text = "Cidade";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(155, 101);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 29;
            label11.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(155, 119);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(95, 23);
            txtEstado.TabIndex = 28;
            // 
            // txtPaís
            // 
            txtPaís.Location = new Point(265, 119);
            txtPaís.Name = "txtPaís";
            txtPaís.Size = new Size(95, 23);
            txtPaís.TabIndex = 30;
            txtPaís.KeyPress += txtPaís_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(265, 101);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 31;
            label12.Text = "País";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.GradientActiveCaption;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F);
            btnSalvar.Location = new Point(530, 475);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 31);
            btnSalvar.TabIndex = 32;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(373, 119);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(156, 23);
            txtComplemento.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(373, 101);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 34;
            label13.Text = "Complemento";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNomeDaMae);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtCPF);
            panel1.Controls.Add(CPF);
            panel1.Controls.Add(txtCelular);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDataNascimento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(28, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 218);
            panel1.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtLogradouro);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtComplemento);
            panel2.Controls.Add(txtNumero);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtPaís);
            panel2.Controls.Add(txtCep);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtBairro);
            panel2.Controls.Add(txtEstado);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtCidade);
            panel2.Location = new Point(28, 289);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 180);
            panel2.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 37;
            label1.Text = "Aluno";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 271);
            label14.Name = "label14";
            label14.Size = new Size(56, 15);
            label14.TabIndex = 38;
            label14.Text = "Endereço";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(647, 545);
            tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(639, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(lvRegistros);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(639, 517);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registros";
            // 
            // lvRegistros
            // 
            lvRegistros.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvRegistros.GridLines = true;
            lvRegistros.Location = new Point(28, 42);
            lvRegistros.Name = "lvRegistros";
            lvRegistros.Size = new Size(587, 405);
            lvRegistros.TabIndex = 0;
            lvRegistros.UseCompatibleStateImageBehavior = false;
            lvRegistros.View = View.Details;
            lvRegistros.Click += lvRegistros_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Matrícula";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Data de Nascimento";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Logradouro";
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Estado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(647, 545);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Cadastro de Alunos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private Label lblNome;
        private MaskedTextBox txtCPF;
        private Label CPF;
        private MaskedTextBox txtCelular;
        private Label label2;
        private MaskedTextBox txtDataNascimento;
        private Label label3;
        private TextBox txtNomeDaMae;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtLogradouro;
        private Label label6;
        private TextBox txtNumero;
        private Label label7;
        private Label label8;
        private MaskedTextBox txtCep;
        private TextBox txtBairro;
        private Label label9;
        private TextBox txtCidade;
        private Label label10;
        private Label label11;
        private TextBox txtEstado;
        private TextBox txtPaís;
        private Label label12;
        private Button btnSalvar;
        private TextBox txtComplemento;
        private Label label13;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label14;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView lvRegistros;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}

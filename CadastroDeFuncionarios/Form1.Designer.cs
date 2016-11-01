namespace CadastroDeFuncionarios
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnMostrarFuncionarios = new System.Windows.Forms.Button();
            this.txtBoxMostrarFunc = new System.Windows.Forms.TextBox();
            this.nUpDownIdade = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFuncionarios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(12, 25);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(114, 20);
            this.txtBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(12, 105);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(114, 20);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(12, 141);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(117, 34);
            this.btnCadastrarFuncionario.TabIndex = 6;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // btnMostrarFuncionarios
            // 
            this.btnMostrarFuncionarios.Location = new System.Drawing.Point(12, 181);
            this.btnMostrarFuncionarios.Name = "btnMostrarFuncionarios";
            this.btnMostrarFuncionarios.Size = new System.Drawing.Size(117, 34);
            this.btnMostrarFuncionarios.TabIndex = 7;
            this.btnMostrarFuncionarios.Text = "Mostrar Funcionários";
            this.btnMostrarFuncionarios.UseVisualStyleBackColor = true;
            this.btnMostrarFuncionarios.Click += new System.EventHandler(this.btnMostrarFuncionarios_Click);
            // 
            // txtBoxMostrarFunc
            // 
            this.txtBoxMostrarFunc.Location = new System.Drawing.Point(167, 12);
            this.txtBoxMostrarFunc.Multiline = true;
            this.txtBoxMostrarFunc.Name = "txtBoxMostrarFunc";
            this.txtBoxMostrarFunc.ReadOnly = true;
            this.txtBoxMostrarFunc.Size = new System.Drawing.Size(414, 324);
            this.txtBoxMostrarFunc.TabIndex = 8;
            // 
            // nUpDownIdade
            // 
            this.nUpDownIdade.Location = new System.Drawing.Point(10, 66);
            this.nUpDownIdade.Name = "nUpDownIdade";
            this.nUpDownIdade.Size = new System.Drawing.Size(120, 20);
            this.nUpDownIdade.TabIndex = 9;
            // 
            // comboBoxFuncionarios
            // 
            this.comboBoxFuncionarios.FormattingEnabled = true;
            this.comboBoxFuncionarios.Items.AddRange(new object[] {
            "Nome",
            "Idade",
            "Email"});
            this.comboBoxFuncionarios.Location = new System.Drawing.Point(10, 234);
            this.comboBoxFuncionarios.Name = "comboBoxFuncionarios";
            this.comboBoxFuncionarios.Size = new System.Drawing.Size(116, 21);
            this.comboBoxFuncionarios.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Buscar funcionário com ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "igual a";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(10, 274);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(118, 20);
            this.txtBoxBuscar.TabIndex = 13;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(12, 300);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(114, 36);
            this.btnBuscarFuncionario.TabIndex = 14;
            this.btnBuscarFuncionario.Text = "Buscar";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 348);
            this.Controls.Add(this.btnBuscarFuncionario);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxFuncionarios);
            this.Controls.Add(this.nUpDownIdade);
            this.Controls.Add(this.txtBoxMostrarFunc);
            this.Controls.Add(this.btnMostrarFuncionarios);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnMostrarFuncionarios;
        private System.Windows.Forms.TextBox txtBoxMostrarFunc;
        private System.Windows.Forms.NumericUpDown nUpDownIdade;
        private System.Windows.Forms.ComboBox comboBoxFuncionarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnBuscarFuncionario;
    }
}


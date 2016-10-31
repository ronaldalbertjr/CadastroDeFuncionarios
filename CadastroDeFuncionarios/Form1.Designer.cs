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
            this.txtBoxIdade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnMostrarFuncionarios = new System.Windows.Forms.Button();
            this.txtBoxMostrarFunc = new System.Windows.Forms.TextBox();
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
            // txtBoxIdade
            // 
            this.txtBoxIdade.Location = new System.Drawing.Point(12, 66);
            this.txtBoxIdade.Name = "txtBoxIdade";
            this.txtBoxIdade.Size = new System.Drawing.Size(114, 20);
            this.txtBoxIdade.TabIndex = 3;
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
            this.txtBoxMostrarFunc.Size = new System.Drawing.Size(414, 300);
            this.txtBoxMostrarFunc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 324);
            this.Controls.Add(this.txtBoxMostrarFunc);
            this.Controls.Add(this.btnMostrarFuncionarios);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnMostrarFuncionarios;
        private System.Windows.Forms.TextBox txtBoxMostrarFunc;
    }
}


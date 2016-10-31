using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CadastroDeFuncionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario(txtBoxNome.Text, Convert.ToInt32(txtBoxIdade.Text), txtBoxEmail.Text);
            func.CadastrarFuncionario();
        }

        private void btnMostrarFuncionarios_Click(object sender, EventArgs e)
        {
            string mostrarFuncionarios = "";
            List<Funcionario> funcs = Funcionario.MostrarFuncionario();
            foreach(Funcionario f in funcs)
            {
                mostrarFuncionarios += "Nome: " + f.Nome + " Idade: " + f.Idade + " Email: " + f.Email + "\r\n";
            }
            Console.Write(mostrarFuncionarios);
            txtBoxMostrarFunc.Text = mostrarFuncionarios;
        }

    }
}

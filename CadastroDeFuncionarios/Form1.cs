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
            Funcionario func = new Funcionario(txtBoxNome.Text, (int) nUpDownIdade.Value, txtBoxEmail.Text);
            func.CadastrarFuncionario();
        }

        private void btnMostrarFuncionarios_Click(object sender, EventArgs e)
        {
            string mostrarFuncionarios = "";
            List<Funcionario> funcs = Funcionario.SalvarFuncionario();
            foreach(Funcionario f in funcs)
            {
                mostrarFuncionarios += "Nome:" + f.Nome + " Idade:" + f.Idade + " Email:" + f.Email + "\r\n";
            }
            listFuncionarios.Items.Add(mostrarFuncionarios);
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            string especificoFuncionario = "";
            List<Funcionario> funcs = Funcionario.BuscarFuncionario(Funcionario.SalvarFuncionario(), comboBoxFuncionarios.Text, txtBoxBuscar.Text);
            foreach (Funcionario f in funcs)
            {
                especificoFuncionario += "Nome:" + f.Nome + " Idade:" + f.Idade + " Email:" + f.Email + "\r\n";
            }
            listFuncionarios.Items.Add(especificoFuncionario);
        }
       

    }
}

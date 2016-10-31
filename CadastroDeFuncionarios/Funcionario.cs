using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CadastroDeFuncionarios
{
    class Funcionario
    {
        private string nome;
        public string Nome
        {
            get 
            {
                return nome;
            }
            set 
            {
                value = nome;
            }
        }
        private int idade;

        public int Idade 
        {
            get 
            {
                return idade;
            }
            set 
            {
                value = idade;
            }
        }

        private string email;
        public string Email
        {
            get 
            {
                return email;
            }
            set
            {
                value = email;
            }
        } 

        public void CadastrarFuncionario()
        {
            Stream arq = File.Open("funcionarios.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(arq);
            writer.WriteLine(nome+"|"+idade.ToString()+"|"+email);
            writer.Close();
            arq.Close();
            
        }

        public static List<Funcionario> MostrarFuncionario()
        {
            string line;
            List<Funcionario> funcs = new List<Funcionario>();
            Stream arq = File.Open("funcionarios.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(arq);
            while ((line = reader.ReadLine()) != null)
            {
                string[] lines = line.Split('|');
                funcs.Add(new Funcionario(lines[0], Convert.ToInt32(lines[1]), lines[2]));
            }
            reader.Close();
            arq.Close();
            return funcs;
        }

        public Funcionario(string nome, int idade, string email)
        {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
        }
    }
}

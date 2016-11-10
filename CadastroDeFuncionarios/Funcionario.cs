using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CadastroDeFuncionarios
{
    [Serializable]
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

        /// <summary>
        /// Função para abrir o arquivo texto e inserir os dados do funcionário dentro desse arquivo texto
        /// </summary>
        public void CadastrarFuncionario()
        {
            Stream arq = File.Open("funcionarios.txt", FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(arq, this);
            arq.Close();
            
        }
        /// <summary>
        /// Função para abrir o arquivo texto e retornar todos os funcionarios salvos dentro desse arquivo texto 
        /// </summary>
        /// <returns>Uma lista de funcionarios com todos os funcionarios cadastrados na arquivo texto</returns>
        public static List<Funcionario> SalvarFuncionario()
        {
            string line;
            List<Funcionario> funcs = new List<Funcionario>();
            Stream arq = File.Open("funcionarios.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            StreamReader reader = new StreamReader(arq);
            while ((line = reader.ReadLine()) != null)
            {
                funcs.Add((Funcionario) bf.Deserialize(arq));
            }
            reader.Close();
            arq.Close();
            return funcs;
        }

        public static List<Funcionario> BuscarFuncionario(List<Funcionario> funcs, string item, string searchedItem)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            foreach(Funcionario f in funcs)
            {
                switch(item)
                {
                    case "Nome":
                        if(f.Nome == searchedItem)
                        {
                            funcionarios.Add(f);
                        }
                        break;
                    case "Idade":
                        if (f.Idade == Convert.ToInt32(searchedItem))
                        {
                            funcionarios.Add(f);
                        }
                        break;
                    case "Email":
                        if (f.Email == searchedItem)
                        {
                            funcionarios.Add(f);
                        }
                        break;
                }
            }
            return funcionarios;
        }

        public Funcionario(string nome, int idade, string email)
        {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
        }
    }
}

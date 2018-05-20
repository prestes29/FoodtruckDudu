using Foodtruck.Negocio;
using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.TelasDudu
{
    class Program
    {
        static Gerenciador gerenciador = new Gerenciador();

        static void Main(string[] args)
        {
        
            int opcao = 0;
            do
            {
                Console.WriteLine("========== FOODTRUCK MANAGER ===========");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0: break;
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    default: Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }

        public static void AdicionarCliente()
        {
            Console.Clear();
            Cliente novoCliente = new Cliente();

            Console.WriteLine("Informe o código:");
            novoCliente.Id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Informe o CPF:");
            novoCliente.CPF = Console.ReadLine();

            Console.WriteLine("Informe o nome:");
            novoCliente.Nome = Console.ReadLine();

            Console.WriteLine("Informe o email:");
            novoCliente.Email = Console.ReadLine();

            Validacao validacao = gerenciador.AdicionarCliente(novoCliente);
            if(validacao.Valido)
            {
                Console.WriteLine("Cliente cadastrado com sucesso");
            }
            else
            {
                foreach(var key in validacao.Mensagens.Keys)
                {
                    String mensagem = validacao.Mensagens[key];
                    Console.WriteLine($"{key} : {mensagem}");
                }
                { 
            }
            Console.ReadLine();
        }

        public static void ListarClientes()
        {
            Console.Clear();
            List<Cliente> clientesCadastrados = gerenciador.TodosOsClientes();
            foreach(Cliente cliente in clientesCadastrados)
            {
                Console.WriteLine(cliente.Descrever());
            }
        }

    }
}

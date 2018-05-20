using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio
{
    public class Gerenciador
    {
        private List<Cliente> Clientes;
        private List<Bebida> Bebidas;
        private List<Lanche> Lanches;
        private List<Pedido> Pedidos;

        public Gerenciador()
        {
            this.Clientes = new List<Cliente>();
            this.Bebidas = new List<Bebida>();
            this.Lanches = new List<Lanche>();
            this.Pedidos = new List<Pedido>();
        }

        public Validacao AdicionarCliente(Cliente clienteAdicionado)
        {
            //Validacoes
            Validacao validacao = new Validacao();
            if(String.IsNullOrEmpty(clienteAdicionado.Nome))
            {
                validacao.Mensagens.Add("Nome", "O nome não pode ser nulo ou vazio");
            }
            if (String.IsNullOrEmpty(clienteAdicionado.Email))
            {
                validacao.Mensagens.Add("Email", "O email não pode ser nulo ou vazio");
            }
            if(validacao.Valido)
            {
                this.Clientes.Add(clienteAdicionado);
            }
            
        }

        public List<Cliente> TodosOsClientes()
        {
            return this.Clientes.ToList();
        }
        public void AdicionarLanche(Lanche lancheAdicionado)
        {
            this.Lanches.Add(lancheAdicionado);
        }
    }
}

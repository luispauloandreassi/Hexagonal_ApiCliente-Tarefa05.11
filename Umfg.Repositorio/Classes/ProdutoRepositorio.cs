using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;
using Umfg.Dominio.Interfaces;

namespace Umfg.Repositorio.Classes
{
    public sealed class ClienteRepositorio : IClienteRepositorio
    {
        private readonly MySqlDataBaseContext _dataBaseContext;

        private DbSet<Cliente> Produtos => _dataBaseContext.Set<Cliente>();

        public ClienteRepositorio(MySqlDataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public void Adicionar(Cliente produto)
        {
            Produtos.Add(produto);
        }

        public List<Cliente> ObterTodos()
        {
            return Produtos.ToList();
        }

        public void Remover(Cliente produto)
        {
            Produtos.Remove(produto);
        }
    }
}

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
    public sealed class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly MySqlDataBaseContext _dataBaseContext;

        private DbSet<Produto> Produtos => _dataBaseContext.Set<Produto>();

        public ProdutoRepositorio(MySqlDataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public void Adicionar(Produto produto)
        {
            Produtos.Add(produto);
        }

        public List<Produto> ObterTodos()
        {
            return Produtos.ToList();
        }

        public void Remover(Produto produto)
        {
            Produtos.Remove(produto);
        }
    }
}

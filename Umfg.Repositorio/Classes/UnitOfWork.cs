using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Interfaces;

namespace Umfg.Repositorio.Classes
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly MySqlDataBaseContext _mySqlDataBaseContext;

        public IClienteRepositorio ClienteRepositorio { get; private set; }

        public UnitOfWork(MySqlDataBaseContext mySqlDataBaseContext,
            IClienteRepositorio clienteRepositorio)
        {
            _mySqlDataBaseContext = mySqlDataBaseContext;
            ClienteRepositorio = clienteRepositorio;
        }

        public void SaveChanges()
        {
            _mySqlDataBaseContext.SaveChanges();
        }
    }
}
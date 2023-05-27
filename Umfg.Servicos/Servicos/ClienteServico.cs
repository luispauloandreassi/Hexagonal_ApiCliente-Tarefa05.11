using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;
using Umfg.Dominio.Interfaces;

namespace Umfg.Aplicacao.Servicos
{
    
    public class ClienteServico : IClienteServico
    {

        private readonly IUnitOfWork _unitOfWork;
        public ClienteServico(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public Cliente Gravar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Documento))
                throw new ArgumentNullException(nameof(cliente.Documento));

         
            _unitOfWork.ClienteRepositorio.Adicionar(cliente);
            _unitOfWork.SaveChanges();

            return cliente;
        }

        public Cliente ObterClientePorDocumento(string documento)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            return _unitOfWork.ClienteRepositorio.ObterTodos();
        }

        public void RemoverPorDocumento(string documento)
        {
            throw new NotImplementedException();
        }
    }

}
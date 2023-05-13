using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Aplicacao.Servicos;
using Umfg.Dominio.Interfaces;
using Umfg.Repositorio.Classes;

namespace Umfg.IoC
{
    public static class Installer
    {
        public static void Dependecy(ref Container container)
        {
            container
                .Register<IProdutoRepositorio, ProdutoRepositorio>(Lifestyle.Singleton);

            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);

            container.Register<IProdutoServico, ProdutoServico>(Lifestyle.Singleton);
        }
    }
}
using Hubtech.Dominio.Contratos;
using Hubtech.Dominio.Entidades;
using Hubtech.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubtech.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(HubTechContexto hubTechContexto) : base(hubTechContexto)
        {

        }
    }
}

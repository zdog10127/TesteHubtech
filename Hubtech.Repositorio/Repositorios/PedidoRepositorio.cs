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
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(HubTechContexto hubTechContexto) : base(hubTechContexto)
        {

        }
    }
}

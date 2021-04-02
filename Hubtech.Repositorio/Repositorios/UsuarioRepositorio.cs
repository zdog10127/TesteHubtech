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
    public class UsuarioRepositorio : BaseRepositorio<Usuario> , IUsuarioRepositorio
    {
        public UsuarioRepositorio(HubTechContexto hubTechContexto) : base(hubTechContexto)
        {

        }
    }
}

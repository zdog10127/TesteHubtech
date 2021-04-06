using Hubtech.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubtech.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
    }
}

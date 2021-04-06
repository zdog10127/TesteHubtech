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

        public Usuario Obter(string email, string senha)
        {
            return Hubtechcontexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}

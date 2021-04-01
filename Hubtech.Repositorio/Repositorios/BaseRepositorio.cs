using Hubtech.Dominio.Contratos;
using Hubtech.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubtech.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly HubTechContexto Hubtechcontexto;
        
        public BaseRepositorio(HubTechContexto hubTechContexto)
        {
            Hubtechcontexto = hubTechContexto;
        }

        public void Adicionar(TEntity entity)
        {
            Hubtechcontexto.Set<TEntity>().Add(entity);
            Hubtechcontexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            Hubtechcontexto.Set<TEntity>().Update(entity);
            Hubtechcontexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return Hubtechcontexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return Hubtechcontexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            Hubtechcontexto.Remove(entity);
            Hubtechcontexto.SaveChanges();
        }
        public void Dispose()
        {
            Hubtechcontexto.Dispose();
        }
    }
}

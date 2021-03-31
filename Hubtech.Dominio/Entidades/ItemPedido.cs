using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubtech.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarMensagemValidacao("Não foi identificado qual a referência do produto");

            if (Quantidade == 0)
                AdicionarMensagemValidacao("Quantidade não foi informado");
        }
    }
}

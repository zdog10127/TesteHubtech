﻿using Hubtech.Dominio.Contratos;
using Hubtech.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtech.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepositorio.ObterTodos());
                
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
               _produtoRepositorio.Adicionar(produto);
                return Created("api/produto", produto);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

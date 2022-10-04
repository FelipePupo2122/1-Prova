using System.Collections.Generic;
using System.Linq;
using API.Models;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/folha")]
    public class FolhaController : ControllerBase
    {
        private readonly DataContext _context;
        public  FolhaController(DataContext context) =>
            _context = context;

        // GET: /api/folha/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Folhas.ToList());

        // POST: /api/folha/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Folha folha)
        {
            _context.Folhas.Add(folha);
            _context.SaveChanges();
            return Created("", folha);
        }

        //GET: /api/folha/buscar/{cpf}/{mes}/{ano}
        [HttpGet]
        [Route("buscar/{cpf}")]
        public IActionResult Buscar([FromRoute] int id)
        {
            Folha folha = _context.Folhas.
                FirstOrDefault(f => f.FuncionarioCpf.Equals(id));
            return folha != null ? Ok(folha) : NotFound();
        }

       // PATCH: /api/folha/filtrar/{mes}/{ano}
        [HttpPatch]
        [Route("filtrar")]
        public IActionResult Filtrar ([FromRoute] DateTime criadoem)
       {
            Folha folha = _context.Folhas.
                FirstOrDefault(f => f.FuncionarioCriadoEm.Equals(criadoem));
            return folha != null ? Ok(folha) : NotFound();
        }
        }
    }

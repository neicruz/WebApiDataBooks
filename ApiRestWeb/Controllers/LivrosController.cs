using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiRestWeb.Models;
using ApiRestWeb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestWeb.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivrosController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_livroRepository.Listar());
        }
    }
}

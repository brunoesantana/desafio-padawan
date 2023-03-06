using Microsoft.AspNetCore.Mvc;
using Models;
using Services.Interfaces;

namespace API.Controllers;

[Route("api/[controller]")]
public class DesafioController : ControllerBase
{
    private readonly IDesafioServices _services;

        public DesafioController(IDesafioServices service)
        {
            _services = service;
        }

        [HttpGet("{numero}")]
        public ActionResult<Resposta> GetDivisores(int numero)
        {
            var divisores = _services.AcharDivisores(numero);
            var divisoresPrimos = _services.AcharDivisoresPrimos(divisores);

            var resposta = new Resposta
            {
                Numero = numero,
                Divisores = divisores,
                DivisoresPrimos = divisoresPrimos
            };
            return Ok(resposta);
        }
}
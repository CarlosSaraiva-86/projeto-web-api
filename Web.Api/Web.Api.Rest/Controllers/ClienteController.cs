using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Api.Domain;
using Web.Api.Domain.Interfaces;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        [HttpGet("ObterTodos")]
        public async Task<ActionResult> ObterTodos()
        {
            return Ok(await clienteRepository.ObterTodos());
        }
        
        [HttpPost("Adicionar")]
        public async Task<ActionResult> AdicionarCliente(Cliente cliente)
        {
            await clienteRepository.Adicionar(cliente);
            return Ok();
        }
    }
}
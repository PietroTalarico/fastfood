using FastFoodAPI.DTO;
using FastFoodAPI.Model;
using FastFoodAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FastFoodAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ClienteRep repo;
        public ClienteController(ClienteRep repo)
        {
            repo = repo;
        }

        [HttpGet]
        public IActionResult All()
        {
            List<Cliente> list = repo.findAll();
            List<ClienteDto> result = list.Select(x => entityToDto(x)).ToList();
            return this.Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Cliente c = repo.FindById(id);
            if (c == null) return this.NotFound();

            ClienteDto result = entityToDto(c);
            return this.Ok(result);
        }

        [HttpPost]
        public IActionResult Save([FromBody] ClienteDto dto)
        {
            Cliente saving = dtoToEntity(dto);
            var result = repo.save(saving);
            return this.Ok(result);
        }

        private ClienteDto entityToDto(Cliente c)
        {
            ClienteDto dto = new ClienteDto();
            dto.id = c.Id;
            dto.nome = c.nome;
            dto.is_vegetariano = c.is_Vegetariano;
            dto.eta = c.eta;

            return dto;
        }

        private Cliente dtoToEntity(ClienteDto dto)
        {
            Cliente c = new Cliente();
            c.id = dto.id;
            c.nome = dto.nome;
            c.is_Vegetariano = dto.is_vegetariano;
            c.eta = dto.eta;
            return c;
        }

    }
}

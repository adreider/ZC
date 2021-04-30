using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TI_Domain.Entities;
using TI_Repository.Interface;
using TI_Webapi.Dtos;

namespace TI_Webapi.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase {
        private readonly IRepository<Empresa> rep;
        private readonly IMapper mapper;

        public EmpresaController (IRepository<Empresa> rep, IMapper mapper) {
            this.rep = rep;
            this.mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get () {
            try {
                var users = await this.rep.GetAllAsync ();
                var results = this.mapper.Map<EmpresaDto[]> (users);

                return Ok(results);
                // return Ok (new EmpresaDto ());
            } catch (System.Exception) {
                return this.StatusCode (StatusCodes.Status500InternalServerError,
                    $"Banco de dados falhou ");
            }
        }

        [HttpGet ("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get (int id) {
            //TELA USUARIO -> ENTIDADE DO BANCO
            try {
                var user = await this.rep.GetByIdAsyncInt (id);

                var result = this.mapper.Map<UserDto> (user);

                return Ok (result);
            } catch (System.Exception ex) {
                return this.StatusCode (StatusCodes.Status500InternalServerError,
                    $"Banco de dados falhou: {ex.Message}");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post (EmpresaDto model) {

           var entity = this.mapper.Map<Empresa>(model);
            await this.rep.Add(entity);

            if(await this.rep.SaveChangesAsync())
                return Created($"/api/empresa", this.mapper.Map<EmpresaDto>(entity));

            return BadRequest();

        }
    }   

}


using APIAlura.Dto;
using APIAlura.Entity;
using APIAlura.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIAlura.Controllers
{
    [ApiController]
    [Route("Usuario")]

   
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        [HttpGet("obter-todos-com-pedidos/{id}")]
        public IActionResult ObterTodosComPedidos([FromRoute]int id)
        {
            return Ok(_usuarioRepository.ObterComPedidos(id));
        
        }

        [HttpGet("Obter-todos-os-usuarios")]
        public IActionResult ChamarTodosUsuarios()
        {
            return Ok(_usuarioRepository.ObterTodos());
        }
        [HttpGet("Obter-usuario-por-id/{id}")]
        public IActionResult ChamarUsuarioID([FromRoute]int id)
        {
            return Ok(_usuarioRepository.ObterPorId(id));
        }
        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody]CadastrarUsuarioDto usuarioDto)
        {
            _usuarioRepository.Cadastrar(new Usuario(usuarioDto));
            return Ok("Usuario Cadastrado com sucesso!");

        }
        [HttpPut]
        public IActionResult EditarUsuario([FromBody]AlterarUsuarioDto usuarioDto)
        {
            _usuarioRepository.Editar(new Usuario(usuarioDto));
            return Ok("Usuario editado com sucesso!");
        }
        [HttpDelete]
        public IActionResult ExcluirUsuario(int id)
        {
            _usuarioRepository.Deletar(id);
            return Ok("Usuario deletado com sucesso!");
        }
    }
}

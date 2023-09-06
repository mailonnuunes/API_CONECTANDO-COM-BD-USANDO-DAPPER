

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


        [HttpGet("Obter-todos-os-usuarios")]
        public IActionResult ChamarTodosUsuarios()
        {
            return Ok(_usuarioRepository.ObterTodos());
        }
        [HttpGet("Obter-usuario-por-id/{id}")]
        public IActionResult ChamarUsuarioID(int id)
        {
            return Ok(_usuarioRepository.ObterPorId(id));
        }
        [HttpPut]
        public void CadastrarUsuario([FromBody]Usuario usuario)
        {
            _usuarioRepository.Cadastrar(usuario);

        }
        [HttpPost]
        public void EditarUsuario([FromBody]Usuario usuario)
        {
            _usuarioRepository.Editar(usuario);
        }
        [HttpDelete]
        public void ExcluirUsuario(int id)
        {
            _usuarioRepository.Deletar(id);
        }
    }
}

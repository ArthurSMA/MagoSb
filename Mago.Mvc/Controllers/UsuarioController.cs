namespace Mago.Mvc.Controllers
{
    [Route("cadastrar")]
    public class UsuarioController : Controller
    {
        public readonly Notification _notification;

        public UsuarioController(
            Notification notification
        )
        {
            _notification = notification;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> Cadastrar(CadastrarUsuarioViewModel cadastrarUsuarioViewModel)
        {
            if (cadastrarUsuarioViewModel == null)
                return BadRequest("Nenhum parâemtro foi enviado!");

            if (!cadastrarUsuarioViewModel.IsValid(_notification))
                return BadRequest(string.Join(" ", _notification.Get()));

            return Ok("Usuario cadastrardo com sucesso!");
        }
    }
}

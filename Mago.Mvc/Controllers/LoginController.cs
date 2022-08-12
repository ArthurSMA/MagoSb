namespace Mago.Mvc.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        public readonly Notification _notification;

        public LoginController(
            Notification notification
        )
        {
            _notification = notification;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> login(LoginViewModel loginViewModel)
        {
            if (loginViewModel == null)
                return BadRequest("Nenhum parâmetro foi enviado!");

            if (!loginViewModel.IsValid(_notification))
                return BadRequest(string.Join(" ", _notification.Get()));

            return Ok("Usuário logado com sucesso!");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Services;

namespace SignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly ChatServices _chatService;
        public ChatController(ChatServices chatService)
        {
            _chatService = chatService;

        }

        [HttpPost("register-user")]
        public IActionResult RegisterUser(UserDto model)
        {

        }

    }
}

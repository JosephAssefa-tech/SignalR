using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Dtos;
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
            if(_chatService.AddUserToList(model.Name))
            {
                return NoContent();
            }
            return BadRequest("This name is already exists");
        }

    }
}

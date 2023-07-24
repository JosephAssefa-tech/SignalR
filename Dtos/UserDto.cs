using System.ComponentModel.DataAnnotations;

namespace SignalR.Dtos
{
    public class UserDto
    {
        [Required]
        public string Name { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BELENOV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UsersController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        // Метод для создания нового пользователя
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] UserDto userDto)
        {
            var newUser = new IdentityUser { UserName = userDto.UserName }; // Создание нового пользователя с указанным именем

            var result = await _userManager.CreateAsync(newUser, userDto.Password); // Добавление пользователя в базу данных

            if (result.Succeeded)
            {
                return Ok(newUser); // Возвращает созданного пользователя в случае успеха
            }
            else
            {
                return BadRequest(result.Errors); // Возвращает ошибки, если создание пользователя не удалось
            }
        }

        // Метод для удаления пользователя по его идентификатору
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId); // Поиск пользователя по его идентификатору

            if (user == null)
            {
                return NotFound(); // Если пользователь не найден, возвращается ошибка 404
            }

            var result = await _userManager.DeleteAsync(user); // Удаление пользователя

            if (result.Succeeded)
            {
                return NoContent(); // Возвращает успешный статус без содержимого (204)
            }
            else
            {
                return BadRequest(result.Errors); // Возвращает ошибки, если удаление пользователя не удалось
            }
        }
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserById(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}

    public class UserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
}





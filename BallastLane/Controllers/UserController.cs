using BallastLane.Application.Services;
using BallastLane.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BallastLane.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class UserController : Controller
	{
		private readonly UserService _userService;

		public UserController(UserService userService)
		{

			_userService = userService;
		}

		[AllowAnonymous]
		[HttpGet]
		public IActionResult GetUsers()
		{
			IEnumerable<User> result = _userService.GetAllUsers();
			return Ok(result);
		}

		[AllowAnonymous]
		[HttpPost]
		public IActionResult InsertUsers(User user)
		{
			_userService.InsertUser(user);
			return Ok();
		}

		[AllowAnonymous]
		[HttpPut]
		public IActionResult UpdateUsers(User user)
		{
			_userService.UpdateUser(user);
			return Ok();
		}

		[AllowAnonymous]
		[HttpDelete]
		public IActionResult DeleteUsers(User user)
		{
			_userService.DeleteUser(user);
			return Ok();
		}

	}
}

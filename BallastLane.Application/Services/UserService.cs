using BallastLane.Core.Entities;
using BallastLane.Core.Interfaces;
using BallastLane.Infrastructure.Repositories;
using BallastLane.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallastLane.Application.Services
{
	public class UserService
	{
		private readonly BallastLaneContext db;
		private IUserRepository userRepository;

		public UserService(BallastLaneContext connection)
		{
			db = connection;
			this.userRepository = new UserRepository(db);
		}

		public IEnumerable<User> GetAllUsers()
		{
			var users = userRepository.GetList().ToList();
			return users;
		}

		public void InsertUser(User post)
		{
			userRepository.Insert(post);
		}

		public void UpdateUser(User update)
		{
			userRepository.Update(update);
		}

		public void DeleteUser(User delete)
		{
			userRepository.Delete(delete);
		}

	}
}

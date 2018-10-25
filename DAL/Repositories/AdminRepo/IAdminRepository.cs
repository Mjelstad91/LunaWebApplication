using Model.AdminModel;
using Model.Models;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public interface IAdminRepository
    {
        bool VerifyAdmin(Login login);
        List<User> ListUsers();

        bool RemoveUser(string Email);
		List<Movie> GetMoviesById();
		byte MovieAvailabilty(int id);
		List<User> GetUsersById();
		byte SetUserStatus(string email);

		byte GetUserStatus(string email);

	}
}
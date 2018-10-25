using DAL.Utilities.Security;
using Model.AdminModel;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class AdminRepository : IAdminRepository
    {
		public bool VerifyAdmin(Login login)
		{
			using (var db = new LunaContext())
			{
				AdminUser adminUser = db.AdminUsers.FirstOrDefault(u => u.Username == login.Username);
				if (adminUser != null)
				{
					byte[] usedPassword = PasswordEncryption.toHash(login.Password, adminUser.Salt);
					return (adminUser.Password.SequenceEqual(usedPassword));
				}
				else
				{
					return false;
				}
			}
		}

        public List<User> ListUsers()
        {
            List<User> AllUsers = new List<User>();
            using(var db = new LunaContext())
            {
                AllUsers = db.Users.ToList();
            }

            return AllUsers;
        }

        public bool RemoveUser(string Email)
        {
            using (var context = new LunaContext())
            {
                var userToDelete = context.Users.FirstOrDefault(e => e.Email == Email);
                if(userToDelete != null)
                {
                    context.Users.Remove(userToDelete);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
		public List<Movie> GetMoviesById()
		{
			List<Movie> moviesById = new List<Movie>();
			using(var context = new LunaContext())
			{
				moviesById = context.Movies.OrderBy(i => i.MovieId).ToList();
			}
			return moviesById;
		}
		public byte MovieAvailabilty(int id)
		{
			try { 
			using(var context = new LunaContext())
			{
				var movie = context.Movies.FirstOrDefault(i => i.MovieId == id);
				{
						if (movie.IsAvailable == 1)
						{
							movie.IsAvailable = 0;
							context.SaveChanges();
						}
						else
						{
							movie.IsAvailable = 1;
							context.SaveChanges();
						}
				}
			}
			return 1;
			}
			catch(Exception e)
			{
				return 0;
			}
		}
		public List<User> GetUsersById()
		{
			List<User> usersById = new List<User>();
			using(var context = new LunaContext())
			{
				usersById = context.Users.OrderBy(u => u.UserId).ToList();
			}
			return usersById;
		}
		public byte SetUserStatus(string email)
		{
			try
			{
				using (var context = new LunaContext())
				{
					var user = context.Users.FirstOrDefault(i => i.Email == email);
					{
						if (user.AccountStatus == 1)
						{
							user.AccountStatus = 0;
							context.SaveChanges();
						}
						else
						{
							user.AccountStatus = 1;
							context.SaveChanges();
						}
					}
				}
				return 1;
			}
			catch (Exception e)
			{
				return 0;
			}
		}
		public byte GetUserStatus(string email)
		{
			try
			{
				using(var context = new LunaContext())
				{
					var user = context.Users.FirstOrDefault(i => i.Email == email);
					if (user.AccountStatus == 1)
					{
						return 1;
					}
					else
						return 0;
				}
			}
			catch(Exception e)
			{
				//ey there
			}
			return 0;
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model.AdminModel;
using Model.Models;
using Model.ViewModels;

namespace PresentationLayer.Controllers
{
    public class AdminController : Controller
    {
        private string adminSession = "adminSession";
        private ILunaLogic _LunaBLL;

        public AdminController()
        {
            _LunaBLL = new LunaBLL();
        }

        public AdminController(ILunaLogic stub)
        {
            _LunaBLL = stub;
        }
        

        public ActionResult Login()
		{
            if(IsAuthorized())
            {
                return RedirectToAction("AdminPanel");
            }
			return View();
		}

		[HttpPost]
		public ActionResult Login(Login loginAdmin)
		{
			if (ModelState.IsValid)
			{
                if (_LunaBLL.VerifyAdmin(loginAdmin))
                {
                    Session[adminSession] = true;
                    return RedirectToAction("AdminPanel");
                }
                else
                {
                    ModelState.AddModelError("Password", "Feil brukernavn eller passord.");
                }
            }

			return View();
		}

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }

		public ActionResult AdminPanel()
		{
            if(IsAuthorized())
            {
                return View();
            }
			return RedirectToAction("Login");
		}

		public ActionResult EditUsers()
		{
			{
				if (IsAuthorized())
				{
					List<User> allUsers = _LunaBLL.GetUsersById();
					return View(allUsers);
				}
				return RedirectToAction("Login");
			}
		}



		[HttpGet]
        public ActionResult DetailedEditUsers(string user)
        {
            if (IsAuthorized())
            {
                User UserInDb = _LunaBLL.GetUser(user);
                return View(UserInDb);
            }
            return RedirectToAction("Login");
        }

		public ActionResult EditMovies()
		{
			if(IsAuthorized())
			{
				List<Movie> allMovies = _LunaBLL.GetMoviesById();
				return View(allMovies);
			}
			return RedirectToAction("Login");
		}
		public ActionResult DetailedEditMovies(int movieId)
		{
			if(IsAuthorized())
			{
				Movie movieInDb = _LunaBLL.GetMovieById(movieId);
				return View(movieInDb);
			}
			return View();
		}

		public ActionResult RemoveUser(string email)
        {
            bool Deletion = _LunaBLL.RemoveUser(email);
            return RedirectToAction("EditUsers");
        }

		public ActionResult SetMovieAvailability(int movieId)
		{
			{
				if (IsAuthorized())
				{
					byte changeSuccess = _LunaBLL.MovieAvailabilty(movieId);
					return RedirectToAction("EditMovies");
				}
				return RedirectToAction("Login");
			}
		}
		public ActionResult SetUserStatus(string email)
		{
			if(IsAuthorized())
			{
				byte changeSuccess = _LunaBLL.SetUserStatus(email);
				return RedirectToAction("EditUsers");
			}
			return RedirectToAction("Login");
		}



		public bool IsAuthorized()
        {
            if (Session[adminSession] != null)
            {
                bool loggedIn = (bool)Session[adminSession];
                if (loggedIn)
                {
                    return true;
                }
            }
            Session[adminSession] = false;
            return false;
        }



    }
}
using System.Collections.Generic;
using Model.AdminModel;
using Model.Models;
using Model.ViewModels;

namespace BLL
{
    public interface ILunaLogic
    {

        bool VerifyAdmin(Login login);

        /******************************************** OBLIGATORISK OPPGAVE 1 ********************************************/
        bool AddCustomer(UserViewModel inUser);
        bool createOrder(List<Movie> movieList, string userEmail);
        List<MovieListViewModel> getAllMovies();
        UserViewModel GetDetailedUser(string userEmail);
        Movie GetMovieById(int id);
        User GetUser(string email);
        MovieViewModel MovieDetail(int id);
        List<JsMovieViewModel> OrderMovie(int orderId);
        bool UserInDB(UserViewModel user);
        List<JsOrderViewModel> UsersOrders(int userid);
        List<User> ListUsers();
        bool RemoveUser(string email);
		List<Movie> GetMoviesById();
		byte MovieAvailabilty(int id);

		List<User> GetUsersById();
		byte SetUserStatus(string email);
		byte GetUserStatus(string email);



	}
}
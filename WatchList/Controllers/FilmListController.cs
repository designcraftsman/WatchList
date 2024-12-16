using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WatchList.Data;
using WatchList.Models;

namespace WatchList.Controllers
{
    public class FilmListController : Controller
    {
        private readonly ApplicationDbContext _contexte;
        private readonly UserManager<User> _gestionnaire;

        public FilmListController(ApplicationDbContext contexte,
           UserManager<User> gestionnaire)
        {
            _contexte = contexte;
            _gestionnaire = gestionnaire;
        }

        private Task<User> GetCurrentUserAsync() =>
           _gestionnaire.GetUserAsync(HttpContext.User);

        [HttpGet]
        public async Task<string> RecupererIdUtilisateurCourant()
        {
            User user = await GetCurrentUserAsync();
            if (user == null)
            {
                Console.WriteLine("User is null. Not logged in?");
                return null;
            }
            Console.WriteLine($"Current User ID: {user.Id}");
            return user?.Id;
        }

        public async Task<IActionResult> Index()
        {
            // Get the current user's ID
            var userId = await RecupererIdUtilisateurCourant();
            if (userId == null)
            {
                return Unauthorized(); // User must be logged in
            }

            // Fetch the user's films along with their details from the database
            var userFilms = await _contexte.FilmUser
                .Where(fu => fu.IdUser == userId)
                .Join(
                    _contexte.ModelViewFilm, // Join with ModelViewFilm
                    fu => fu.IdFilm,         // Join on IdFilm
                    mf => mf.IdFilm,         // Match on IdFilm
                    (fu, mf) => new ModelViewFilm
                    {
                        IdFilm = mf.IdFilm,
                        Title = mf.Title,
                        Year = mf.Year,
                        PresentInList = true,
                        View = fu.Viewed,
                        Note = fu.Note
                    }
                )
                .ToListAsync();

            return View(userFilms);
        }



        [HttpPost]
        public async Task<IActionResult> AddFilm(int idFilm)
        {
            try
            {
                var currentUser = await GetCurrentUserAsync();
                if (currentUser == null)
                {
                    return BadRequest("User not found.");
                }

                var filmUser = new FilmUser
                {
                    IdUser = currentUser.Id, // Ensure the correct user ID is assigned
                    IdFilm = idFilm,
                    Viewed = false,
                    Note = 0
                };

                _contexte.FilmUser.Add(filmUser);
                await _contexte.SaveChangesAsync();

                return Ok("Film added successfully!");
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                Console.WriteLine($"Error adding film: {ex.Message}");
                if (ex.InnerException != null)
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");

                return StatusCode(500, "An error occurred while adding the film.");
            }
        }






        [HttpPost]
        public async Task<IActionResult> RemoveFilm(int idFilm)
        {
            var idUser = await RecupererIdUtilisateurCourant();
            if (idUser == null)
            {
                return Unauthorized(); // User must be logged in.
            }

            // Find the film in the user's watchlist.
            var filmToRemove = await _contexte.FilmUser
                .FirstOrDefaultAsync(fu => fu.IdUser == idUser && fu.IdFilm == idFilm);

            if (filmToRemove == null)
            {
                return BadRequest("Film is not in your watchlist."); // Prevent invalid deletions.
            }

            // Remove the film.
            _contexte.FilmUser.Remove(filmToRemove);
            await _contexte.SaveChangesAsync();

            return Ok("Film removed from your watchlist.");
        }



    }
}

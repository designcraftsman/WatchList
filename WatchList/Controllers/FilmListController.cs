using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
            return user?.Id;
        }
        public async Task<IActionResult> Index()
        {
            var id = await RecupererIdUtilisateurCourant();
            var FilmUser = _contexte.FilmUser.Where(x => x.IdUser == id);
            var modele = FilmUser.Select(x => new ModelViewFilm
            {
                IdFilm = x.IdFilm,
                Title = x.Film.Title,
                Year = x.Film.Year,
                View = x.Viewed,
                PresentInList = true,
                Note = x.Note
            }).ToList();

            return View(modele);
        }
    }
}

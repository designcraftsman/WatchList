namespace WatchList.Data
{
    public class User : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public User() : base()
        {
            this.ListFilms = new HashSet<FilmUser>();
        }

        public string Prenom { get; set; }
        public virtual ICollection<FilmUser> ListFilms { get; set; }
    }
}

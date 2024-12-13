namespace WatchList.Data
{
    public class User : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public User() : base()
        {
            this.FilmsList = new HashSet<FilmUser>();
        }

        public string LastName { get; set; }
        public virtual ICollection<FilmUser> FilmsList { get; set; }
    }
}

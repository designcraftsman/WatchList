namespace WatchList.Data
{
    public class FilmUser
    {
        public string IdUser { get; set; }
        public int IdFilm { get; set; }
        public bool Viewed { get; set; }
        public int Note { get; set; }

        public virtual User User { get; set; }
        public virtual Film Film { get; set; }
    }
}

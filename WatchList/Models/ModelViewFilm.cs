using System.ComponentModel.DataAnnotations;

namespace WatchList.Models
{
    public class ModelViewFilm
    {
        [Key]
        public int IdFilm { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public bool PresentInList { get; set; }
        public bool View { get; set; }
        public int Note { get; set; }
    }
}

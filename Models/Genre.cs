using System.ComponentModel.DataAnnotations;

namespace ApiEfProject.Models
{
    public class Genre
    {
        //Constructor
        public Genre(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        //One Genre has Many Movies
        public ICollection<Movie>? Movies { get; set; }
    }
}

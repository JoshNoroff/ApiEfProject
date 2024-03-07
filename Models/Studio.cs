using System.ComponentModel.DataAnnotations;

namespace ApiEfProject.Models
{
    public class Studio
    {
        //Constructor
        public Studio(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        //One Studio has Many Movies
        public ICollection<Movie>? Movies { get; set; }
    }
}

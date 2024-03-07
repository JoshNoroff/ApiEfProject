using System.ComponentModel.DataAnnotations;

namespace ApiEfProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TicketPrice { get; set; }

        //Foreign Key
        public int GenreId { get; set; }
        //Navigation property
        public Genre? Genre { get; set; }

        //Foreign Key
        public int StudioId { get; set; }
        //Navigation property
        public Studio? Studio { get; set; }

        //Many movies have many Actors 
        public virtual ICollection<MovieActor>? MovieActors { get; set; }
    }
}

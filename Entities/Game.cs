using System;

namespace fistproject.Entities;

public class Game
{
    public int Id {get; set;}

    public required string Name {get; set;}

    public int GenreId {get; set;}

    public Genre Genre {get; set;}

    public float Price {get; set;}

    public DateTime ReleaseDate {get; set;}

}

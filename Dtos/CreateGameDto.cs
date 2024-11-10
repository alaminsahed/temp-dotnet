using System.ComponentModel.DataAnnotations;

namespace fistproject.Dtos;

public record class CreateGameDto(
   [Required][StringLength(50)] string Name,
   [Required][StringLength(20)]string Description,
   [Range(1,100)]decimal Price,
    DateOnly ReleaseDate
);

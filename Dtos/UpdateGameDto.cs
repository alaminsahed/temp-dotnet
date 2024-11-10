namespace fistproject.Dtos;

public record class UpdateGameDto(
    string Name,
    string Description,
    decimal Price,
    DateOnly ReleaseDate
);

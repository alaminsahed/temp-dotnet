using fistproject.Dtos;

namespace fistproject.Endpoint;

public static class GamesEndpoints
{
   private static readonly List<GameDto> games = [
    new GameDto(1, "GTA V", "Grand Theft Auto Vi", 29.99m, new DateOnly(2013, 9, 17)),
    new GameDto(2, "Cyberpunk 2078", "Cyberpunk 2077", 59.99m, new DateOnly(2020, 12, 10)),
];

public static RouteGroupBuilder MapsGameEndpoints(this WebApplication app){

var group = app.MapGroup("games");

group.MapGet("/", () => games);
group.MapPost("/", (CreateGameDto game) => {
    var newGame = new GameDto(games.Count + 1, game.Name, game.Description, game.Price, game.ReleaseDate);
    games.Add(newGame);
    return newGame;
}).WithParameterValidation();
group.MapPut("/{id}", (int id, UpdateGameDto updateGame) => {
    var index = games.FindIndex(g => g.Id == id);
   games[index] = games[index] with {
       Name = updateGame.Name,
       Description = updateGame.Description,
       Price = updateGame.Price,
       ReleaseDate = updateGame.ReleaseDate
   };
    return games;

});
    return group;
}
}


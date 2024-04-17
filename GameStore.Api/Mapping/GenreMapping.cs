using GameStore.Api.DTOs;
using GameStore.Api.Entities;

namespace GameStore.Api.Mapping;

public static class GenreMapping
{
    public static GenreDTO ToDTO(this Genre genre)
    {
        return new GenreDTO(genre.Id, genre.Name);
    }
}

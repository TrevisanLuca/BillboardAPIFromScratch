using System.ComponentModel.DataAnnotations;

namespace BillboardAPIFromScratch.Dtos
{
    public record AuthorForCreateDto(
        [Required][MinLength(2)]
        string Name,
        [Required][MinLength(2)]
        string Surname,
        [Required][EmailAddress]
        string Email
        );
}
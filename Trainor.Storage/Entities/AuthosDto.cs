using System.ComponentModel.DataAnnotations;

namespace Trainor.Storage.Entities
{
    public record AuthorDetailsDto(int Id, string GivenName, string LastName) { }
    public record AuthorCreateDto()
    {
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string GivenName { get; init; }

        [StringLength(50)]
        public string LastName { get; init; }
    }
    public record AuthorDto(string GivenName, string LastName)
    {
        [StringLength(50)]
        public string GivenName { get; init; }

        [StringLength(50)]
        public string LastName { get; init; }
    }

    public record AuthorUpdateDto : AuthorCreateDto
    {
        public int Id { get; set; }
    }
}
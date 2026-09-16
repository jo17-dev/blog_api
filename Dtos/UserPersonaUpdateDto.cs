using System.ComponentModel.DataAnnotations;
using blog_api.Enums;

namespace blog_api.Dtos;

public class UserPersonaUpdateDto
{
    [Required]
    public Guid Id {get; set;}

    [MinLength(2)]
    public string? Fullname {get; set;}

    [MinLength(2)]
    public string? Email {get; set;}

    public string? Socials {get; set;}

    public Lang? PreferedLang {get; set;}

    [MinLength(2)]
    public string? Bio {get; set;} = null;
}
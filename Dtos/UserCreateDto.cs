using System.ComponentModel.DataAnnotations;
using blog_api.Enums;

namespace blog_api.Dtos;

public class UserPersonaCreateDto
{
    [Required]
    [MinLength(2)]
    public string Fullname {get; set;} = string.Empty;

    [Required]
    [MinLength(2)]
    public string Email {get; set;} = string.Empty;

    public string? Socials {get; set;}

    [Required]
    [EnumDataType(typeof(Lang))]
    public Lang PreferedLang {get; set;}

    [MinLength(2)]
    public string? Bio {get; set;} = null;
}
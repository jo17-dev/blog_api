using System.ComponentModel.DataAnnotations;
using blog_api.Enums;

namespace blog_api.Dtos;

public class PostLocalizedCreateDto
{
    [Required]
    [EnumDataType(typeof(Lang))]
    public Lang Lang {get; set;}

    [Required]
    [EnumDataType(typeof(PostStatus))]
    public PostStatus Status {get; set;}

    [Required] // validation au niveau de la requette
    [MinLength(2)]
    public string Title {get; set;} = string.Empty;

    [Required]
    [MinLength(2)]
    public string Content {get; set;} = string.Empty;
}
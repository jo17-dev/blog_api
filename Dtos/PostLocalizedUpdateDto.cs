using System.ComponentModel.DataAnnotations;
using blog_api.Enums;

namespace blog_api.Dtos;

public class PostLocalizedUpdateDto
{
    [Required]
    public Guid Id {get; set;}

    [EnumDataType(typeof(Lang))]
    public Lang? Lang {get; set;}

    [EnumDataType(typeof(PostStatus))]
    public PostStatus? Status {get; set;}

    [MinLength(2)]
    public string? Title {get; set;}

    [MinLength(2)]
    public string? Content {get; set;}
}
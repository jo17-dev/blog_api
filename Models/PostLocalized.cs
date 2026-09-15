using System.ComponentModel.DataAnnotations;
using blog_api.Enums;

namespace blog_api.Models;

public class PostLocalized
{
    [Key]
    public Guid Id {get; set;}

    [Required]
    public Guid PostId {get; set;}

    [Required]
    [EnumDataType(typeof(Lang))]
    public Lang Lang {get; set;}

    [Required]
    [EnumDataType(typeof(PostStatus))]
    public PostStatus Status {get; set;}

    [Required]
    [MinLength(2)]
    public string Title {get; set;} = string.Empty;

    [Required]
    [MinLength(2)]
    public string Content {get; set;} = string.Empty;

    public Post? Post {get; set;}
}
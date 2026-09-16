using System.ComponentModel.DataAnnotations;

namespace blog_api.Dtos;

public class PostCreateDto {

    [Required]
    public PostLocalizedCreateDto[] Localized {get; set;} = [];
    public  string? LinkedPostId {get; set;} = null;
}
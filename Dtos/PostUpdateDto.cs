using System.ComponentModel.DataAnnotations;

namespace blog_api.Dtos;

public class PostUpdateDto {

    [Required]
    public Guid Id {get; set;}

    public PostLocalizedCreateDto[]? Localized {get; set;} = [];
    public  string? LinkedPostId {get; set;} = null;
}
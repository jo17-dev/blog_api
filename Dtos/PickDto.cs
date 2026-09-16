using System.ComponentModel.DataAnnotations;

namespace blog_api.Dtos;

public class PickDto {

    [Required]
    public string Id {get; set;} = string.Empty;
}
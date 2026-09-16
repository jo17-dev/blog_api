namespace blog_api.Dtos;

public class PostDto {
    public Guid Id {get; set;}
    
    public UserDto Owner  {get; set;}

    public long? PublishedAt {get; set;} = null;

    public PostLocalizedDto[] Localized {get; set;} = [];

    public  PostDto? LinkedPost {get; set;} = null;

    public long CreatedAt {get; set;}
    public long? UpdatedAt {get; set;}
}
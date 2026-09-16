using blog_api.Enums;

namespace blog_api.Dtos;

public class PostLocalizedDto
{
    public Guid Id {get; set;}
    public Lang Lang {get; set;}
    public PostStatus Status {get; set;}
    public long CreatedAt {get; set;}
    public long? UPdatedAt {get; set;} = null;
}
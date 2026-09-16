namespace blog_api.Dtos;

public class UserDto {
    public Guid Id {get; set;}
    public UserPersonaDto? PersonaDto {get; set;}
    public long? LastLoginAt {get; set;} = null;
}
using System.ComponentModel.DataAnnotations;
using blog_api.Enums;

namespace blog_api.Dtos;

public class UserPersonaDto {
    public Guid Id {get; set;}

    public UserDto UserDto {get; set;}
    
    public string? Fullname {get; set;}

    public string? Email {get; set;}

    public string? Socials {get; set;}

    public Lang PreferedLang {get; set;}

    public string? Bio {get; set;} = null;

    public long CreatedAt {get; set;}
    public long? UPdatedAt {get; set;} = null;
}
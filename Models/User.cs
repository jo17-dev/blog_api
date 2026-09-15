using System.ComponentModel.DataAnnotations;
using blog_api.Enums;

namespace blog_api.Models;

public class User {
    [Key]
    public Guid Id {get; set;}
    
    [Required]
    public Guid PersonaId {get; set;}

    [Required]
    [EnumDataType(typeof(UserRole))]
    public UserRole UserRole {get; set;}

    [Required]
    [EnumDataType(typeof(UserStatus))]
    public UserStatus Status {get; set;}
    
    public long? LastLoginAt {get; set;} = null;

    public UserPersona? Persona {get; set;}
}
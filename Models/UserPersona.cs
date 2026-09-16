using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using blog_api.Enums;

namespace blog_api.Models;

public class UserPersona {
    [Key]
    public Guid Id {get; set;}

    [Required]
    public string? Fullname {get; set;}

    [Required]
    [EmailAddress]
    public string? Email {get; set;}
    
    [Required]
    public Lang PreferedLang {get; set;}

    public string? Bio {get; set;} = null;

    public string? Socials {get; set;} = null;

    [DefaultValue(false)]
    public bool IsDeleted {get; set;}
        
    public long CreatedAt {get; set;}
    public long? UPdatedAt {get; set;} = null;
}
using System.ComponentModel;

namespace blog_api.Models;

public class Post {
    public Guid Id {get; set;}
    public Guid OwnerId  {get; set;}
    public long? PublishedAt {get; set;} = null;
    public  Guid? LinkedPostId {get; set;} = null;

    [DefaultValue(false)]
    public bool IsDeleted {get; set;}
    // 
    public User? Owner {get; set;}
    public Post? LinkedPost {get; set;}
}
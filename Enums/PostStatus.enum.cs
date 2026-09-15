namespace blog_api.Enums;

public enum PostStatus {
    SAVED = 0, // save for publish later
    PUBLISHED = 1, // published
    UNPUBLISHED = 2, // published and then removed
}
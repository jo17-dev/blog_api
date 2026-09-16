namespace blog_api.Exceptions;

// ceci vont être des codes d'erreurs spécifiques qui peuvent être internationalisé et affichés pour les frontends
public enum CustomErrorCode
{
    NOT_DOCUMENTED=0,
    INVALID_CREDENTIALS=1,
    NOT_AUTHENTICATED=2,
}
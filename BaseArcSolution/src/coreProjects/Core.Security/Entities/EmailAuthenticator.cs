using Core.Persistance;

namespace Core.Security.Entities;

public class EmailAuthenticator : BaseEntity
{
    public string UserId { get; set; }
    public string? ActivationKey { get; set; }
    public bool IsVerified { get; set; }

    public virtual AppUser User { get; set; }

    public EmailAuthenticator()
    {
    }

    public EmailAuthenticator(string id, string userId, string? activationKey, bool isVerified) : this()
    {
        Id = id;
        UserId = userId;
        ActivationKey = activationKey;
        IsVerified = isVerified;
    }
}
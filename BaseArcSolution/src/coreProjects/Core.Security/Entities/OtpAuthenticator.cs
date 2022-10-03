using Core.Persistance;

namespace Core.Security.Entities;

public class OtpAuthenticator : BaseEntity
{
    public string UserId { get; set; }
    public byte[] SecretKey { get; set; }
    public bool IsVerified { get; set; }

    //public virtual User User { get; set; }

    public OtpAuthenticator()
    {
    }

    public OtpAuthenticator(string id, string userId, byte[] secretKey, bool isVerified) : this()
    {
        Id = id;
        UserId = userId;
        SecretKey = secretKey;
        IsVerified = isVerified;
    }
}
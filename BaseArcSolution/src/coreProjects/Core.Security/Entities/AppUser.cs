using Core.Persistance;
using Core.Security.Enums;
using Microsoft.AspNetCore.Identity;

namespace Core.Security.Entities;

public class AppUser : IdentityUser<string>
{
    public string NameSurname { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenEndDate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

//public class User :BaseEntity
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string Email { get; set; }
//    public byte[] PasswordSalt { get; set; }
//    public byte[] PasswordHash { get; set; }
//    public bool Status { get; set; }
//    public AuthenticatorType AuthenticatorType { get; set; }

//    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
//    public virtual ICollection<RefreshToken> RefreshTokens { get; set; }

//    public User()
//    {
//        UserOperationClaims = new HashSet<UserOperationClaim>();
//        RefreshTokens = new HashSet<RefreshToken>();
//    }

//    public User(Guid id, string firstName, string lastName, string email, byte[] passwordSalt, byte[] passwordHash,
//                bool status, AuthenticatorType authenticatorType) : this()
//    {
//        Id = id;
//        FirstName = firstName;
//        LastName = lastName;
//        Email = email;
//        PasswordSalt = passwordSalt;
//        PasswordHash = passwordHash;
//        Status = status;
//        AuthenticatorType = authenticatorType;
//    }
//}
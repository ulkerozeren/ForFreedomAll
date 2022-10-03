using Core.Persistance;

namespace Core.Security.Entities;

public class UserOperationClaim : BaseEntity
{
    public string UserId { get; set; }
    public int OperationClaimId { get; set; }

    public virtual AppUser User { get; set; }
    public virtual OperationClaim OperationClaim { get; set; }

    public UserOperationClaim()
    {
    }

    public UserOperationClaim(string id, string userId, int operationClaimId) : base(id)
    {
        UserId = userId;
        OperationClaimId = operationClaimId;
    }
}
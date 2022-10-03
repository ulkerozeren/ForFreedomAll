using Core.Persistance;

namespace Core.Security.Entities;

public class OperationClaim : BaseEntity
{
    public string Name { get; set; }

    public OperationClaim()
    {
    }

    public OperationClaim(string id, string name) : base(id)
    {
        Name = name;
    }
}
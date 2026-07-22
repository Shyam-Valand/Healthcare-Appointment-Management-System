using Healthcare.Domain.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Patient : AuditableEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public DateOnly DateOfBirth { get; set; }

    public Gender Gender { get; set; }

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;
}
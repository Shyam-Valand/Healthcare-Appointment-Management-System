using Healthcare.Domain.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Appointment : AuditableEntity
{
    public Guid PatientId { get; set; }

    public Guid DoctorId { get; set; }

    public DateTimeOffset AppointmentDate { get; set; }

    public AppointmentStatus Status { get; set; }
}
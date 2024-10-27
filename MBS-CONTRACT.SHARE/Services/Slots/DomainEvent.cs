using MBS_CONTRACT.SHARE.Abstractions.Messages;

namespace MBS_CONTRACT.SHARE.Services.Slots;
public static class DomainEvent
{
    //list of slot created
    public record SlotsCreated(Guid IdEvent, IEnumerable<Slot> Slots) : IDomainEvent, ICommand;

    public record ChangeSlotStatusInToBooked(Guid IdEvent, Guid SlotId) : IDomainEvent, ICommand;

    public record SlotUpdated(Guid IdEvent, Slot Slot) : IDomainEvent, ICommand;

    public class Slot
    {
        public Guid SlotId { get; set; }
        public Guid? MentorId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateOnly Date { get; set; }
        public bool IsOnline { get; set; }
        public string? Note { get; set; }
        public short? Month { get; set; }
        public bool IsBook { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset CreatedOnUtc { get; set; }
        public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
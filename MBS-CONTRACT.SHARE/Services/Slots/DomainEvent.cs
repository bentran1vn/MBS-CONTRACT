using MBS_CONTRACT.SHARE.Abstractions.Messages;

namespace MBS_CONTRACT.SHARE.Services.Slots;

public static class DomainEvent
{
   //list of slot created
   public record SlotsCreated(Guid IdEvent, List<SLot> Slots) : IDomainEvent, ICommand;

   public class SLot
   {
      public Guid? MentorId { get; set; }
      public TimeOnly StartTime { get; set; }
      public TimeOnly EndTime { get; set; }
      public DateOnly Date { get; set; }
      public bool IsOnline { get; set; }
      public string? Note { get; set; }
      public short? Month { get; set; }
      public bool IsBook { get; set; }
      public DateTimeOffset CreatedOnUtc { get; set; }
      public DateTimeOffset? ModifiedOnUtc { get; set; }
    }
}
using System;


namespace ConvertionEntities.Entities
{
    public record RoomDetails(
         string Id,
         string Name,
         int ParticipantCount,
         int MaxParticipants);
    //public record RoomDetails {
    //    public string Id { get; init; }
    //    public string Name { get; init; }

    //    public int ParticipantCount { get; init; }
    //    public int MaxParticipants { get; init; }
    //};

}

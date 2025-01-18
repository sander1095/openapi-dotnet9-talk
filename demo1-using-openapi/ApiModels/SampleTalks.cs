namespace ApiModels;
public class SampleTalks
{
    public static readonly List<TalkModel> Talks =
    [
        new() { Id = 1, Title = "OpenAPI", LengthInMinutes = 50, RoomName = "Room 1" },
        new() { Id = 2, Title = "Dapr", LengthInMinutes = 50, RoomName = "Room 1" },
        new() { Id = 3, Title = "GenAI", LengthInMinutes = 50, RoomName = "Room 2" },
        new() { Id = 4, Title = "Managed Identities", LengthInMinutes = 50, RoomName = "Room 1" },
        new() { Id = 5, Title = "Q#", LengthInMinutes = 50, RoomName = "Room 2" },
        new() { Id = 6, Title = "GitHub Actions", LengthInMinutes = 50, RoomName = "Room 2" },
        new() { Id = 7, Title = "Duplo and Domain Knowledge", LengthInMinutes = 50, RoomName = "Room 1" }
    ];
}

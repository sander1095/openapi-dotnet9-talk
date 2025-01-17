namespace ApiModels;
public class SampleTalks
{
    public static readonly List<TalkModel> Talks = [
        new() { Id = 1, Title = "OpenAPI", LengthInMinutes = 50, RoomName = "Room 1" },
        new() { Id = 2, Title = "Sustainable Software", LengthInMinutes = 50, RoomName = "Room 2" },
        new() { Id = 3, Title = "Code dependencies", LengthInMinutes = 50, RoomName = "Room 2" },
        new() { Id = 4, Title = "Open source", LengthInMinutes = 50, RoomName = "Room 1" },
        new() { Id = 5, Title = "Security Scorecards", LengthInMinutes = 50, RoomName = "Room 2" },
        new() { Id = 6, Title = "Entra", LengthInMinutes = 50, RoomName = "Room 1" },
        new() { Id = 7, Title = "Github Codespaces", LengthInMinutes = 50, RoomName = "Room 2" }
];
}

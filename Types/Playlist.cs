using graphQL.Data;

namespace graphQL.Types;

[GraphQLDescription("A curated collection of tracks designed for a specific activity or mood.")]
public class Playlist
{
    [GraphQLDescription("The ID for the playlist.")]
    [ID]
    public string Id { get; }

    [GraphQLDescription("The name of the playlist.")]
    public string Name { get; set; }

    [GraphQLDescription("Describes the playlist, what to expect and entices the user to listen.")]
    public string? Description { get; set; }

    [GraphQLDescription("The playlist's tracks.")]
    public List<Track> Tracks { get; set; }

    public Playlist(string id, string name)
    {
        Id = id;
        Name = name;
    }
    public Playlist(PlaylistSimplified obj)
    {
        Id = obj.Id;
        Name = obj.Name;
        Description = obj.Description;
    }

    public Playlist(Data.Playlist obj)
    {
        Id = obj.Id;
        Name = obj.Name;
        Description = obj.Description;

        // var paginatedTracks = obj.Tracks.Items;
        // var trackObjects = paginatedTracks.Select(item => new Track(item.Track));
        // Tracks = trackObjects.ToList();


        Tracks = obj.Tracks.Items.Select(item => new Track(item.Track)).ToList(); // above three lines do the same thing
    }
}

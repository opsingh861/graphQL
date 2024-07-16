using graphQL.Data;

namespace graphQL.Types;

public class Query
{

    [GraphQLDescription("Playlists hand-picked to be featured to all users.")]
    public async Task<List<Playlist>> FeaturedPlaylists(SpotifyService spotifyService)
    {
        var response = await spotifyService.GetFeaturedPlaylistsAsync();
        // var items = response.Playlists.Items;
        // var playlists = items.Select(item => new Playlist(item));
        // return playlists.ToList();  // or we can do it in one line
        return response.Playlists.Items.Select(item => new Playlist(item)).ToList();
    }

        [GraphQLDescription("Retrieves a specific playlist.")]
    public async Task<Playlist?> GetPlaylist([ID] string id, SpotifyService spotifyService)
    {
        var response = await spotifyService.GetPlaylistAsync(id);
        var playlist = new Playlist(response);
        return playlist;
    }
}

namespace graphQL.Types;

public class Query
{
    public string Hello()
    {
        return "Hello world";
    }

    [GraphQLDescription("Playlists hand-picked to be featured to all users.")]
    public List<Playlist> FeaturedPlaylists()
    {
        //     return new List<Playlist> // we can write or use short hand which is below
        //   {
        //       new("1", "GraphQL Groovin'"),
        //       new("2", "Graph Explorer Jams"),
        //       new("3", "Interpretive GraphQL Dance")
        //   };
        return
      [
          new("1", "GraphQL Groovin"),
          new("2", "Graph Explorer Jams"),
          new("3", "Interpretive GraphQL Dance")
      ];
    }
}

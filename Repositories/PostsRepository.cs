using System.Data;

namespace csharp_auth0_taskmaster.Repositories
{
  public class PostsRepository
  {
    private readonly IDbConnection _db;

    public PostsRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}
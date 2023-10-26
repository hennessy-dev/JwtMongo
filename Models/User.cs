using MongoDB.Driver;
using MongoDbGenericRepository.Attributes;
using AspNetCore.Identity.MongoDbCore.Models;

namespace JwtMongo.Models;
[CollectionName("users")]
public class User : MongoIdentityUser<Guid>
{
    public string FullName { get; set; } = string.Empty;
}


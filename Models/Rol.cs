using MongoDbGenericRepository.Attributes;
using AspNetCore.Identity.MongoDbCore.Models;

namespace JwtMongo.Models;
[CollectionName("roles")]
public class Rol : MongoIdentityRole<Guid>
{}


using AlisonSilvaIdentityUser.Models.MongoDBCollections.PoesiasDB;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AlisonSilvaIdentityUser.Repositories.MongoDBRepositories
{
    public class PoesiaRepository
    {
        private readonly IMongoCollection<Poesia> _poesiaCollection;

        public PoesiaRepository(IOptions<PoesiasDbSettings> poesiaServices)
        {
            var mongoClient = new MongoClient(poesiaServices.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(poesiaServices.Value.DatabaseName);

            _poesiaCollection = mongoDatabase.GetCollection<Poesia>(poesiaServices.Value.PoesiasCollectionName);
        }

        public async Task<List<Poesia>> GetPoesiasAsync()
            => await _poesiaCollection.Find(x => true)
                     .ToListAsync();

        public async Task<Poesia> GetPoesiaAsync(string? id)
            => await _poesiaCollection.Find(x => true)
                    .FirstOrDefaultAsync();

        public async Task CreateAsync(Poesia poesia)
            => await _poesiaCollection.InsertOneAsync(poesia);

        public async Task UpdateAsync(string id, Poesia poesia)
            => await _poesiaCollection.ReplaceOneAsync(x => x.Equals(id), poesia);

        public async Task DeleteAsync(string id)
            => await _poesiaCollection.DeleteOneAsync(x => x.Equals(id));
    }
}

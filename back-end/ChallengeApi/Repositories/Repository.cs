using MongoDB.Driver;

namespace ChallengeApi.Repositories
{
    public interface IRepository
    {
        IMongoDatabase GetDatabase();
    }
    public class Repository : IRepository
    {
        private const string CONNECTION_STRING = "mongodb+srv://challenge:challenge2019@challenge-bingi.mongodb.net/test?retryWrites=true&w=majority";
        private const string DB_NAME = "challenge";
        protected IMongoDatabase db;
        public Repository()
        {
            Connect();
        }

        protected void Connect()
        {
            MongoClient client;
            MongoUrl url = new MongoUrl(CONNECTION_STRING);
            MongoClientSettings clientSettings = MongoClientSettings.FromUrl(url);
            clientSettings.UseSsl = true;
            clientSettings.VerifySslCertificate = false;
            clientSettings.SslSettings = new SslSettings()
            {
                CheckCertificateRevocation = false
            };
            client = new MongoClient(clientSettings);
            db = client.GetDatabase(DB_NAME);
        }

        public IMongoDatabase GetDatabase()
        {
            return db;
        }
    }
}
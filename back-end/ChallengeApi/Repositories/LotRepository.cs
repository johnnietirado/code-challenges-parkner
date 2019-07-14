using System;
using System.Collections.Generic;
using ChallengeApi.Models;
using MongoDB.Driver;

namespace ChallengeApi.Repositories
{

    public interface ILotRepository
    {
        List<Lot> GetLots();
        Lot GetLot(string id);
    }

    public class LotRepository : ILotRepository
    {
        private IMongoCollection<Lot> _lots;
        public LotRepository(IRepository repository)
        {
            _lots = repository.GetDatabase().GetCollection<Lot>("lots");
        }

        public List<Lot> GetLots()
        {
            return _lots.Find(Lot => true).ToList();
        }

        public Lot GetLot(string id)
        {
            return _lots.Find(lot => lot.Id == id).FirstOrDefault();
        }
    }
}
using System.Collections.Generic;
using ChallengeApi.Models;
using ChallengeApi.Repositories;

namespace ChallengeApi.Services
{

    public interface ILotService
    {
        List<Lot> GetLots();
        Lot GetLot(string id);
    }

    public class LotService : ILotService
    {
        private readonly ILotRepository _lots;

        public LotService(ILotRepository lots)
        {
            _lots = lots;
        }

        public List<Lot> GetLots() => _lots.GetLots();

        public Lot GetLot(string id)
        {
            return _lots.GetLot(id);
        }
    }
}
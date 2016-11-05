using HiFive.Models;
using System.Collections.Generic;

namespace HiFive.Repositories
{
    public interface IHiFiveRepository
    {
        void AddOrUpdate(HiFiveRecord item);
        IEnumerable<HiFiveRecord> GetAll();
        HiFiveRecord Find(string key);
        void Remove(string key);
        void Update(HiFiveRecord item);
    }
}
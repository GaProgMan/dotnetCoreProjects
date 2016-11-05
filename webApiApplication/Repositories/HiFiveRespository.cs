using HiFive.Contexts;
using HiFive.Models;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;

namespace HiFive.Repositories
{
    public class HiFiveRespository : IHiFiveRepository 
    {
        HiFiveContext _context;
        public HiFiveRespository(HiFiveContext context)
        {
            _context = context;
        }

        public void AddOrUpdate(HiFiveRecord item)
        {

            // Old post, but AddOrUpdate should only be used
            // in migrations, according to this:
            // http://thedatafarm.com/data-access/take-care-with-ef-4-3-addorupdate-method/
            if (Find(item.HiFiver) == null)
            {
                _context.HiFiveRecords.Add(item);
            }
            else
            {
                Update(item);
            }
            _context.SaveChanges();
        }

        public HiFiveRecord Find(string key)
        {
            return _context.HiFiveRecords
                .Where(hiFive => hiFive.HiFiver == key)
                .SingleOrDefault();
        }

        // don't do this in real code.
        public IEnumerable<HiFiveRecord> GetAll()
        {
            return _context.HiFiveRecords;//.AsNoTracking();
        }

        public void Remove(string key)
        {
            var itemToRemove = _context.HiFiveRecords
                .SingleOrDefault(hiFive => hiFive.HiFiver == key);
            if (itemToRemove != null)
            {
                _context.HiFiveRecords.Remove(itemToRemove);   
                _context.SaveChanges();         
            }
        }

        public void Update(HiFiveRecord item)
        {
            var itemToUpdate = _context.HiFiveRecords
                .SingleOrDefault(hiFive => hiFive.HiFiver == item.HiFiver);
            if (itemToUpdate != null)
            {
                // update fields here

                _context.SaveChanges();
            }
        }
    }
}
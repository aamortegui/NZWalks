using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class SQLRegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext _dbcontext;
        public SQLRegionRepository(NZWalksDbContext dbContext) 
        {
            _dbcontext = dbContext;
        }

        public async Task<List<Region>> GetAllAsync()
        {
            return await _dbcontext.Regions.ToListAsync();
        }
        public async Task<Region?> GetByIdAsync(Guid id)
        {
           return  await _dbcontext.Regions.FirstOrDefaultAsync(x=>x.Id == id);
        }
        public async Task<Region> CreateRegionAsync(Region region)
        {
            await _dbcontext.Regions.AddAsync(region);
            await _dbcontext.SaveChangesAsync();
            return region;
        }

        public async Task<Region?> UpdateRegionAsync(Guid id, Region region)
        {
            var existingRegion = await _dbcontext.Regions.FirstOrDefaultAsync(x=>x.Id==id);

            if (existingRegion == null) 
            {
                return null;
            }
            existingRegion.Code = region.Code;
            existingRegion.Name = region.Name;
            existingRegion.RegionImageUrl = region.RegionImageUrl;
            await _dbcontext.SaveChangesAsync();

            return existingRegion;
        }

        public async Task<Region?> DeleteRegionAsync(Guid id)
        {
            var existingRegion = _dbcontext.Regions.FirstOrDefault(x=>x.Id==id);
            if (existingRegion == null) 
            {
                return null;
            }

            _dbcontext.Regions.Remove(existingRegion);
            await _dbcontext.SaveChangesAsync();
            return existingRegion;
        }
    }
}

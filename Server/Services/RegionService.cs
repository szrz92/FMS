using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Services
{
    public static class RegionService
    {
        public static async Task<List<string>> GetRegions(AppDbContext dbContext, string role)
        {
            List<string> Regions = new List<string>();
            if (role == "SA" || role == "HMT")
            {
                Regions = await (from r in dbContext.Regions
                                 select r.XDescription).Take(5).ToListAsync();
            }
            else /*if (role == "SA")*/
            {
                Regions = await (from r in dbContext.Regions

                                 select r.XDescription).ToListAsync();
            }
            return Regions;
        }
    }
}

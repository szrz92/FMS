using SOS.FMS.Server.Models;
using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Services
{
    public class AssetsService
    {
        private readonly AppDbContext context;

        public AssetsService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task AddOrUpdateAsset(string code, string description,
            AssetType assetType,
            string stationCode)
        {
            //var asset = context.Assets.FirstOrDefault(x => x.Code == code);
            //if (asset == null)
            //{
            //    asset = new Asset()
            //    {
            //        Id = Guid,
            //        Code = code,
            //        AssetType = assetType,
            //        AcquisitionDate = DateTime.UtcNow,
            //        UpdatedAt = DateTime.UtcNow,
            //        UpdateBy = "ImportScript"
            //    };

            //    context.Assets.Add(asset);

            //}
            //asset.Description = description;
            //var statoin = context.Parties.FirstOrDefault(x => x.ShortName == stationCode);
            //asset.StationId = statoin.Id;
            //asset.SubregionId = statoin.SubregionId;
            //asset.RegionId = statoin.RegionId;

            //await context.SaveChangesAsync();
        }
    }
}

using DataProvider.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;

namespace WinHRMS.Models
{
    public class AssetView : Asset
    {
        public string Name { get { return AssetName; } }
        public string Type { get { return AssetType; } }
        public DateTime ValidFrom { get { return AssetValidFrom; } }
        public DateTime ValidThru { get { return AssetValidThru; } }
        public Double DaysToExpairy { get { return this.AssetValidThru.Subtract(this.AssetValidFrom).TotalDays; } }

        internal static List<AssetView> getList(DataStore context)
        {
            List<AssetView> result = new List<AssetView>();
            var temp = Asset.getAssetList(context);
            foreach (var item in temp)
            {
                result.Add(
                    new AssetView()
                    {
                        AssetId = item.AssetId,
                        AssetLocation = item.AssetLocation,
                        AssetName = item.AssetName,
                        AssetType = item.AssetType,
                        AssetValidFrom = item.AssetValidFrom,
                        AssetValidThru = item.AssetValidThru,
                        ExtraInfo = item.ExtraInfo
                    }
                    );
            }
            return result;
        }
    }
}

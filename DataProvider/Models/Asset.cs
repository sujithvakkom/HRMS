using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    [ComplexType]
    public class Asset
    {
        [Column("AssetId")]
        public int AssetId { get; set; }

        [Column("AssetName")]
        public String AssetName { get; set; }
        [Column("AssetLocation")]
        public String AssetLocation { get; set; }
        [Column("AssetType")]
        public String AssetType { get; set; }
        [Column("AssetValidFrom")]
        public DateTime AssetValidFrom { get; set; }
        [Column("AssetValidThru")]
        public DateTime AssetValidThru { get; set; }
        [Column("ExtraInfo")]
        public String ExtraInfo { get; set; }

        protected static List<Asset> getAssetList(DbContext context, String AssetName = null)
        {
            try
            {
                var assetFoud =
                context.Database.SqlQuery<Asset>(@"SELECT a.[AssetId] ,
       a.[AssetName] ,
       a.[AssetLocation] ,
       t.[Name] as [AssetType] ,
       a.[AssetValidFrom] ,
       a.[AssetValidThru] ,
       a.[ExtraInfo]
FROM [dbo].[Asset] AS a inner join [dbo].[HR_DOCTYPE] t on a.DocTypeId = t.DocTypeId
WHERE a.AssetName = ISNULL(@AssetName, a.AssetName)",
new SqlParameter("@AssetName", AssetName == null ? (Object)DBNull.Value : (Object)AssetName)
                    );
                return assetFoud.ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }

        }
        public void Save(DbContext context)
        {

            Asset assetFoud = null;
            try
            {
                if (this.AssetName != null)
                    assetFoud =
                        Asset.getAssetList(context, this.AssetName).First();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            if (assetFoud != null)
            {
                this.AssetId = assetFoud.AssetId;
                assetFoud.AssetLocation = this.AssetLocation;
                assetFoud.AssetName = this.AssetName;
                assetFoud.AssetType = this.AssetType;
                assetFoud.AssetValidFrom = this.AssetValidFrom;
                assetFoud.AssetValidThru = this.AssetValidThru;
                var assetTypeId = HRDocType.Get(this.AssetName, context).DocTypeId;
                context.Database.ExecuteSqlCommand(
                    @"UPDATE [dbo].[Asset]
       SET
           [AssetName] = @AssetName ,
           [AssetLocation] = @AssetLocation ,
           [DocTypeId] = @DocTypeId ,
           [AssetValidFrom] = @AssetValidFrom ,
           [AssetValidThru] = @AssetValidThru ,
           [ExtraInfo] = @ExtraInfo
WHERE [AssetId] = @AssetId",
new SqlParameter("@AssetName", this.AssetName),
new SqlParameter("@AssetLocation", this.AssetLocation),
new SqlParameter("@DocTypeId", assetTypeId),
new SqlParameter("@AssetValidFrom", this.AssetValidFrom),
new SqlParameter("@AssetValidThru", this.AssetValidThru),
new SqlParameter("@ExtraInfo", this.ExtraInfo == null ? (Object)DBNull.Value : (Object)this.ExtraInfo),
new SqlParameter("@AssetId", this.AssetId)
                    );
            }
            else
            {
                var assetTypeId = HRDocType.Get(this.AssetType, context).DocTypeId;
                context.Database.ExecuteSqlCommand(
                    @"INSERT INTO [dbo].[Asset] ( [AssetName] ,
                            [AssetLocation] ,
                            [DocTypeId] ,
                            [AssetValidFrom] ,
                            [AssetValidThru] ,
                            [ExtraInfo]
                          )
VALUES ( @AssetName ,
         @AssetLocation ,
         @DocTypeId ,
         @AssetValidFrom ,
         @AssetValidThru ,
         @ExtraInfo
       )",
new SqlParameter("@AssetName", this.AssetName),
new SqlParameter("@AssetLocation", this.AssetLocation),
new SqlParameter("@DocTypeId", assetTypeId),
new SqlParameter("@AssetValidFrom", this.AssetValidFrom),
new SqlParameter("@AssetValidThru", this.AssetValidThru),
new SqlParameter("@ExtraInfo", this.ExtraInfo == null ? (Object)DBNull.Value : (Object)this.ExtraInfo));
            }
        }

        public static Asset get(DbContext context,string AssetName)
        { 

            Asset assetFoud = null;
            try
            {
                assetFoud =
                context.Database.SqlQuery<Asset>(@"SELECT a.[AssetId] ,
       a.[AssetName] ,
       a.[AssetLocation] ,
       a.[AssetType] ,
       a.[AssetValidFrom] ,
       a.[AssetValidThru] ,
       a.[ExtraInfo]
FROM [dbo].[Asset] AS a
WHERE a.AssetName = @AssetName",
    new SqlParameter("@AssetName", AssetName)

                    ).First();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return assetFoud;
        }
    }
}
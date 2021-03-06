using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_subcategory_list", DwStyle.Grid)]
    [Table("ProductSubcategory", Schema = "Production")]
    #region DwSelectAttribute  
    [DwSelect("SELECT production.productsubcategory.productsubcategoryid, " 
                  + "production.productsubcategory.productcategoryid, "
                  + "production.productsubcategory.name, "
                  + "production.productsubcategory.modifieddate "
                  + "FROM production.productsubcategory "
                  + "where (production.productsubcategory.productcategoryid = :ai_id or :ai_id = 0)")]
    #endregion
    [DwParameter("ai_id", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Subcategory_List
    {
        [Identity]
        [Key]
        public int Productsubcategoryid { get; set; }

        [ConcurrencyCheck]
        public int? Productcategoryid { get; set; }

        [ConcurrencyCheck]
        public string Name { get; set; }

        [ConcurrencyCheck]
        public DateTime? Modifieddate { get; set; }

    }

}

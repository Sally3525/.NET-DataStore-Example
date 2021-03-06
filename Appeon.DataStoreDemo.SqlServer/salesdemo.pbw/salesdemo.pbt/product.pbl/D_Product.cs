using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_product", DwStyle.Grid)]
    [Table("Product", Schema = "Production")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"production.product\" ) COLUMN(NAME=\"production.product.productid\") COLUMN(NAME=\"production.product.name\") COLUMN(NAME=\"production.product.productnumber\") COLUMN(NAME=\"production.product.makeflag\") COLUMN(NAME=\"production.product.color\") COLUMN(NAME=\"production.product.safetystocklevel\") COLUMN(NAME=\"production.product.reorderpoint\") COLUMN(NAME=\"production.product.standardcost\") COLUMN(NAME=\"production.product.listprice\") COLUMN(NAME=\"production.product.size\") COLUMN(NAME=\"production.product.sizeunitmeasurecode\") COLUMN(NAME=\"production.product.weightunitmeasurecode\") COLUMN(NAME=\"production.product.weight\") COLUMN(NAME=\"production.product.daystomanufacture\") COLUMN(NAME=\"production.product.productline\") COLUMN(NAME=\"production.product.class\") COLUMN(NAME=\"production.product.style\") COLUMN(NAME=\"production.product.productsubcategoryid\") COLUMN(NAME=\"production.product.productmodelid\") COLUMN(NAME=\"production.product.sellstartdate\") COLUMN(NAME=\"production.product.sellenddate\") COLUMN(NAME=\"production.product.modifieddate\") COLUMN(NAME=\"production.product.finishedgoodsflag\")WHERE(    EXP1 =\"production.product.productsubcategoryid\"   OP =\"=\"    EXP2 =\":al_subcate\" ) ) ARG(NAME = \"al_subcate\" TYPE = number) ")]
    #endregion
    [DwParameter("al_subcate", typeof(decimal?))]
    [DwSort("productsubcategoryid A productid A ")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Product
    {
        [Identity]
        [Key]
        public int Productid { get; set; }

        public string Name { get; set; }

        public string Productnumber { get; set; }

        [SqlDefaultValue("((1))")]
        public bool Makeflag { get; set; }

        public string Color { get; set; }

        public int Safetystocklevel { get; set; }

        public int Reorderpoint { get; set; }

        public decimal Standardcost { get; set; }

        public decimal Listprice { get; set; }

        public string Size { get; set; }

        public string Sizeunitmeasurecode { get; set; }

        public string Weightunitmeasurecode { get; set; }

        public decimal? Weight { get; set; }

        public int Daystomanufacture { get; set; }

        public string Productline { get; set; }

        public string Class { get; set; }

        public string Style { get; set; }

        public int? Productsubcategoryid { get; set; }

        public int? Productmodelid { get; set; }

        public DateTime Sellstartdate { get; set; }

        public DateTime? Sellenddate { get; set; }

        [SqlDefaultValue("(getdate())")]
        public DateTime Modifieddate { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("((1))")]
        public bool Finishedgoodsflag { get; set; }

    }

}

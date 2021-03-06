using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_order_production", DwStyle.Grid)]
    [Table("Product", Schema = "Production")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Production.Product\" )  TABLE(NAME=\"Production.ProductCategory\" )  TABLE(NAME=\"Production.ProductModel\" )  TABLE(NAME=\"Production.ProductSubcategory\" ) COLUMN(NAME=\"Production.Product.Name\") COLUMN(NAME=\"Production.Product.ProductNumber\") COLUMN(NAME=\"Production.Product.Color\") COLUMN(NAME=\"Production.Product.ListPrice\") COLUMN(NAME=\"Production.Product.Size\") COLUMN(NAME=\"Production.Product.ProductSubcategoryID\") COLUMN(NAME=\"Production.Product.ProductModelID\") COLUMN(NAME=\"Production.ProductCategory.Name\") COLUMN(NAME=\"Production.ProductSubcategory.ProductCategoryID\") COLUMN(NAME=\"Production.ProductSubcategory.Name\") COLUMN(NAME=\"Production.ProductModel.Name\") COLUMN(NAME=\"Production.Product.ProductID\")    JOIN (LEFT=\"Production.ProductModel.ProductModelID\"    OP =\"=\"RIGHT=\"Production.Product.ProductModelID\" )    JOIN (LEFT=\"Production.ProductSubcategory.ProductCategoryID\"    OP =\"=\"RIGHT=\"Production.ProductCategory.ProductCategoryID\" )    JOIN (LEFT=\"Production.ProductSubcategory.ProductSubcategoryID\"    OP =\"=\"RIGHT=\"Production.Product.ProductSubcategoryID\" )WHERE(    EXP1 =\"~\"Production~\".~\"Product~\".~\"FinishedGoodsFlag~\"\"   OP =\"=\"    EXP2 =\"1\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"~\"Production~\".~\"Product~\".~\"ProductID~\"\"   OP =\"in\" NEST = PBSELECT( VERSION(400) TABLE(NAME=\"Sales.SpecialOfferProduct\" ) COLUMN(NAME=\"Sales.SpecialOfferProduct.ProductID\"))) ) ORDER(NAME=\"Production.Product.ProductID\" ASC=yes ) ")]
    #endregion
    [DwSort("product_productnumber A ")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Order_Production
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string Product_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Product_Productnumber { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Product_Color { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal Product_Listprice { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Product_Size { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int? Product_Productsubcategoryid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int? Product_Productmodelid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Productcategory_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int Productsubcategory_Productcategoryid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Productsubcategory_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Productmodel_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int Product_Productid { get; set; }

    }

}

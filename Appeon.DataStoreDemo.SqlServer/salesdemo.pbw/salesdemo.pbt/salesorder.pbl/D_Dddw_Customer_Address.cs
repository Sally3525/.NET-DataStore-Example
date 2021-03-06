using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_customer_address", DwStyle.Grid)]
    [Table("BusinessEntityAddress", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.BusinessEntityAddress\" )  TABLE(NAME=\"Person.Address\" )  TABLE(NAME=\"Person.AddressType\" )  TABLE(NAME=\"Sales.Customer\" )  TABLE(NAME=\"Person.StateProvince\" ) COLUMN(NAME=\"Person.BusinessEntityAddress.BusinessEntityID\") COLUMN(NAME=\"Person.BusinessEntityAddress.AddressID\") COLUMN(NAME=\"Person.BusinessEntityAddress.AddressTypeID\") COLUMN(NAME=\"Person.Address.AddressLine1\") COLUMN(NAME=\"Person.Address.AddressLine2\") COLUMN(NAME=\"Person.Address.City\") COLUMN(NAME=\"Person.Address.StateProvinceID\") COLUMN(NAME=\"Person.Address.PostalCode\") COLUMN(NAME=\"Person.AddressType.Name\") COLUMN(NAME=\"Sales.Customer.CustomerID\") COLUMN(NAME=\"Person.StateProvince.StateProvinceCode\") COLUMN(NAME=\"Person.StateProvince.CountryRegionCode\") COLUMN(NAME=\"Person.StateProvince.Name\")    JOIN (LEFT=\"Person.Address.AddressID\"    OP =\"=\"RIGHT=\"Person.BusinessEntityAddress.AddressID\" )    JOIN (LEFT=\"Person.AddressType.AddressTypeID\"    OP =\"=\"RIGHT=\"Person.BusinessEntityAddress.AddressTypeID\" )    JOIN (LEFT=\"Sales.Customer.TerritoryID\"    OP =\"=\"RIGHT=\"Person.StateProvince.TerritoryID\" )WHERE(    EXP1 =\"(~\"Person~\".~\"BusinessEntityAddress~\".~\"BusinessEntityID~\"\"   OP =\"=\"    EXP2 =\"~\"Sales~\".~\"Customer~\".~\"PersonID~\"\"    LOGIC =\"or\" ) WHERE(    EXP1 =\"~\"Person~\".~\"BusinessEntityAddress~\".~\"BusinessEntityID~\"\"   OP =\"=\"    EXP2 =\"~\"Sales~\".~\"Customer~\".~\"StoreID~\")\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"~\"Person~\".~\"Address~\".~\"StateProvinceID~\"\"   OP =\"=\"    EXP2 =\"~\"Person~\".~\"StateProvince~\".~\"StateProvinceID~\"\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"~\"Sales~\".~\"Customer~\".~\"CustomerID~\"\"   OP =\"=\"    EXP2 =\":al_customer_id\" ) ) ARG(NAME = \"al_customer_id\" TYPE = number) ")]
    #endregion
    [DwParameter("al_customer_id", typeof(decimal?))]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Customer_Address
    {
        [PropertySave(SaveStrategy.Ignore)]
        public int Businessentityaddress_Businessentityid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int Businessentityaddress_Addressid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int Businessentityaddress_Addresstypeid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Address_Addressline1 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Address_Addressline2 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Address_City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int Address_Stateprovinceid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Address_Postalcode { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Addresstype_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int Customer_Customerid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Stateprovince_Stateprovincecode { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Stateprovince_Countryregioncode { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Stateprovince_Name { get; set; }

    }

}

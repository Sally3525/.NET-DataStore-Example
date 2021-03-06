using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_order_header_grid", DwStyle.Grid)]
    [Table("SalesOrderHeader", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.SalesOrderHeader\" ) COLUMN(NAME=\"Sales.SalesOrderHeader.salesorderid\") COLUMN(NAME=\"Sales.SalesOrderHeader.revisionnumber\") COLUMN(NAME=\"Sales.SalesOrderHeader.orderdate\") COLUMN(NAME=\"Sales.SalesOrderHeader.duedate\") COLUMN(NAME=\"Sales.SalesOrderHeader.shipdate\") COLUMN(NAME=\"Sales.SalesOrderHeader.status\") COLUMN(NAME=\"Sales.SalesOrderHeader.onlineorderflag\") COLUMN(NAME=\"Sales.SalesOrderHeader.salesordernumber\") COLUMN(NAME=\"Sales.SalesOrderHeader.purchaseordernumber\") COLUMN(NAME=\"Sales.SalesOrderHeader.accountnumber\") COLUMN(NAME=\"Sales.SalesOrderHeader.customerid\") COLUMN(NAME=\"Sales.SalesOrderHeader.salespersonid\") COLUMN(NAME=\"Sales.SalesOrderHeader.territoryid\") COLUMN(NAME=\"Sales.SalesOrderHeader.billtoaddressid\") COLUMN(NAME=\"Sales.SalesOrderHeader.shiptoaddressid\") COLUMN(NAME=\"Sales.SalesOrderHeader.shipmethodid\") COLUMN(NAME=\"Sales.SalesOrderHeader.creditcardid\") COLUMN(NAME=\"Sales.SalesOrderHeader.creditcardapprovalcode\") COLUMN(NAME=\"Sales.SalesOrderHeader.currencyrateid\") COLUMN(NAME=\"Sales.SalesOrderHeader.subtotal\") COLUMN(NAME=\"Sales.SalesOrderHeader.taxamt\") COLUMN(NAME=\"Sales.SalesOrderHeader.freight\") COLUMN(NAME=\"Sales.SalesOrderHeader.totaldue\") COLUMN(NAME=\"Sales.SalesOrderHeader.comment\") COLUMN(NAME=\"Sales.SalesOrderHeader.modifieddate\")WHERE(    EXP1 =\"Sales.SalesOrderHeader.OrderDate\"   OP =\"between\"    EXP2 =\":adt_start and :adt_end\"    LOGIC =\"And\" ) WHERE(    EXP1 =\"(Sales.SalesOrderHeader.CustomerID\"   OP =\"=\"    EXP2 =\":al_cust_id\"    LOGIC =\"or\" ) WHERE(    EXP1 =\":al_cust_id\"   OP =\"=\"    EXP2 =\"0)\" ) ) ORDER(NAME=\"Sales.SalesOrderHeader.orderdate\" ASC=no) ARG(NAME = \"adt_start\" TYPE = datetime)  ARG(NAME = \"adt_end\" TYPE = datetime)  ARG(NAME = \"al_cust_id\" TYPE = number) ")]
    #endregion
    [DwParameter("adt_start", typeof(DateTime?))]
    [DwParameter("adt_end", typeof(DateTime?))]
    [DwParameter("al_cust_id", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Order_Header_Grid
    {
        [Identity]
        [Key]
        public int Salesorderid { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((0))")]
        public Byte Revisionnumber { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        public DateTime Orderdate { get; set; }

        [ConcurrencyCheck]
        public DateTime Duedate { get; set; }

        [ConcurrencyCheck]
        public DateTime? Shipdate { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((1))")]
        public Byte Status { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((1))")]
        public bool Onlineorderflag { get; set; }

        [ConcurrencyCheck]
        public string Salesordernumber { get; set; }

        [ConcurrencyCheck]
        public string Purchaseordernumber { get; set; }

        [ConcurrencyCheck]
        public string Accountnumber { get; set; }

        [ConcurrencyCheck]
        [DwChild("Customer_Customerid", "Full_Name", typeof(D_Dddw_Customer_Individual))]
        public int Customerid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Salesperson_Businessentityid", "Full_Name", typeof(D_Dddw_Salesperson))]
        public int? Salespersonid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Salesterritory_Territoryid", "Salesterritory_Name", typeof(D_Dddw_Salesterritory))]
        public int? Territoryid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Businessentityaddress_Addressid", "Address_Addressline1", typeof(D_Dddw_Customer_Address))]
        public int Billtoaddressid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Businessentityaddress_Addressid", "Address_Addressline1", typeof(D_Dddw_Customer_Address))]
        public int Shiptoaddressid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Shipmethodid", "Name", typeof(D_Dddw_Shipmethod))]
        public int Shipmethodid { get; set; }

        [ConcurrencyCheck]
        public int? Creditcardid { get; set; }

        [ConcurrencyCheck]
        public string Creditcardapprovalcode { get; set; }

        [ConcurrencyCheck]
        public int? Currencyrateid { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((0.00))")]
        public decimal Subtotal { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((0.00))")]
        public decimal Taxamt { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((0.00))")]
        public decimal Freight { get; set; }

        [ConcurrencyCheck]
        public decimal Totaldue { get; set; }

        [ConcurrencyCheck]
        public string Comment { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        public DateTime Modifieddate { get; set; }

        [DwCompute("getrow()")]
        public object Compute_Row { get; set; }

    }

}

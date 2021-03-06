using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_currency_rate", DwStyle.Grid)]
    [Table("CurrencyRate", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.CurrencyRate\" ) COLUMN(NAME=\"Sales.CurrencyRate.CurrencyRateID\") COLUMN(NAME=\"Sales.CurrencyRate.CurrencyRateDate\") COLUMN(NAME=\"Sales.CurrencyRate.FromCurrencyCode\") COLUMN(NAME=\"Sales.CurrencyRate.ToCurrencyCode\") COLUMN(NAME=\"Sales.CurrencyRate.AverageRate\") COLUMN(NAME=\"Sales.CurrencyRate.EndOfDayRate\")WHERE(    EXP1 =\"Sales.CurrencyRate.CurrencyRateDate\"   OP =\"=\"    EXP2 =\"(select max(CurrencyRateDate) from Sales.CurrencyRate )\" ) ) ORDER(NAME=\"Sales.CurrencyRate.ToCurrencyCode\" ASC=yes ) ")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Dddw_Currency_Rate
    {
        [Identity]
        [Key]
        public int Currencyrateid { get; set; }

        [ConcurrencyCheck]
        public DateTime Currencyratedate { get; set; }

        [ConcurrencyCheck]
        public string Fromcurrencycode { get; set; }

        [ConcurrencyCheck]
        public string Tocurrencycode { get; set; }

        [ConcurrencyCheck]
        public decimal Averagerate { get; set; }

        [ConcurrencyCheck]
        public decimal Endofdayrate { get; set; }

    }

}

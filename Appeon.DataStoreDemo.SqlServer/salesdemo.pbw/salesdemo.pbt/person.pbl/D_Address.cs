using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_address", DwStyle.Grid)]
    [Table("Address", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("SELECT Person.Address.addressid, " 
                  + "Person.Address.addressline1, "
                  + "Person.Address.addressline2, "
                  + "Person.Address.city, "
                  + "Person.Address.stateprovinceid, "
                  + "Person.Address.postalcode, "
                  + "Person.Address.modifieddate "
                  + "FROM Person.Address "
                  + "where (Person.Address.stateprovinceid = :stateId or :stateId = 0) "
                  + "and (Person.Address.city like :city)")]
    #endregion
    [DwParameter("stateId", typeof(decimal?))]
    [DwParameter("city", typeof(string))]
    [DwSort("addressid A ")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Address
    {
        [Identity]
        [Key]
        public int Addressid { get; set; }

        [ConcurrencyCheck]
        public string Addressline1 { get; set; }

        [ConcurrencyCheck]
        public string Addressline2 { get; set; }

        [ConcurrencyCheck]
        public string City { get; set; }

        [ConcurrencyCheck]
        [DwChild("Stateprovinceid", "Name", typeof(D_Dddw_Stateprovince))]
        public int? Stateprovinceid { get; set; }

        [ConcurrencyCheck]
        public string Postalcode { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public DateTime? Modifieddate { get; set; }

    }

}

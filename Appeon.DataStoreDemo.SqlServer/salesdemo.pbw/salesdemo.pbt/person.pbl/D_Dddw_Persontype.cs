using DWNet.Data;
using SnapObjects.Data;
using System.Collections.Generic;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_persontype", DwStyle.Grid)]
    [DwSort("persontype A ")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    [DwData(typeof(D_Dddw_Persontype_Data))]
    public class D_Dddw_Persontype
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string Persontype { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Typedesc { get; set; }

    }

    #region D_Dddw_Persontype_Data
    public class D_Dddw_Persontype_Data : DwDataInitializer<D_Dddw_Persontype>
    {
        public override IList<D_Dddw_Persontype> GetDefaultData()
        {
            var datas = new List<D_Dddw_Persontype>()
            { 
                 new D_Dddw_Persontype() { Persontype = "SC", Typedesc = "Store Contact " },  
                 new D_Dddw_Persontype() { Persontype = "IN ", Typedesc = "Individual (retail) customer " },  
                 new D_Dddw_Persontype() { Persontype = "SP ", Typedesc = "Sales person " },  
                 new D_Dddw_Persontype() { Persontype = "EM ", Typedesc = "Employee (non-sales) " },  
                 new D_Dddw_Persontype() { Persontype = "VC ", Typedesc = "Vendor contact " },  
                 new D_Dddw_Persontype() { Persontype = "GC ", Typedesc = "General contact " },              
            };

            return datas;
        }
    }
    #endregion
}

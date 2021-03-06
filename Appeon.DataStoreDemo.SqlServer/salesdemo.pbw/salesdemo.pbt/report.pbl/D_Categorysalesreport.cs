using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_categorysalesreport", DwStyle.Default)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Categorysalesreport
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string Productcategoryname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsalesqty { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsaleroom { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Lasttotalsalesqty { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Lasttotalsaleroom { get; set; }

    }

}

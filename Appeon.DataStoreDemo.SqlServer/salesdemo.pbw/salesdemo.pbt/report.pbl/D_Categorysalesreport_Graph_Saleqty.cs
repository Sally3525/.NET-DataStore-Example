using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_categorysalesreport_graph_saleqty", DwStyle.Graph)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Categorysalesreport_Graph_Saleqty
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string Productcategoryname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsalesqty { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsaleroom { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Year { get; set; }

    }

}

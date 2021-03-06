using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_subcategorysalesreport_graph", DwStyle.Graph)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Subcategorysalesreport_Graph
    {
        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Month { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsalesqty { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsaleroom { get; set; }

    }

}

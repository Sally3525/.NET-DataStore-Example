using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_subcategorysalesreport", DwStyle.Default)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Subcategorysalesreport
    {
        public string Name { get; set; }

        public int? Salesqtymonth1 { get; set; }

        public decimal? Salesroommonth1 { get; set; }

        public int? Salesqtymonth2 { get; set; }

        public decimal? Salesroommonth2 { get; set; }

        public int? Salesqtymonth3 { get; set; }

        public decimal? Salesroommonth3 { get; set; }

        public int? Salesqtymonth4 { get; set; }

        public decimal? Salesroommonth4 { get; set; }

        public int? Salesqtymonth5 { get; set; }

        public decimal? Salesroommonth5 { get; set; }

        public int? Salesqtymonth6 { get; set; }

        public decimal? Salesroommonth6 { get; set; }


    }

}

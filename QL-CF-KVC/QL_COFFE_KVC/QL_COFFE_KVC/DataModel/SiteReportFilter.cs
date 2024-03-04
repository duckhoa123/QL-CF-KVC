using System.Collections.Generic;

namespace QL_COFFE_KVC
{
    public sealed class SiteReportFilter
    {
        public static List<Param> Instance { get; } = new List<Param> { new Param("Tất cả sản phẩm", "*"), new Param("Sản phẩm bán chạy nhất", "0"), new Param("Sản phẩm tồn kho nhiều nhất", "1") };
    }
}

using System.Collections.Generic;

namespace QL_COFFE_KVC
{
    public sealed class AvaiableTableDataSource
    {
        public static List<Param> Instance { get; } = new List<Param> { new Param("Còn trống", "0"), new Param("Đã đặt bàn", "1"), new Param("Đang sử dụng", "2"), new Param("Chờ thanh toán", "3") };
    }
}

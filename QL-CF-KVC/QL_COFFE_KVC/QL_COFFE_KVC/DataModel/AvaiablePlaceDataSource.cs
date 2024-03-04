using System.Collections.Generic;

namespace QL_COFFE_KVC
{
    public sealed class AvaiablePlaceDataSource
    {
        public static List<Param> Instance { get; } = new List<Param> { new Param("Còn trống", "0"), new Param("Đã đặt khu", "1"), new Param("Đang hoạt động", "2"), new Param("Đầy", "3") };
    }
}

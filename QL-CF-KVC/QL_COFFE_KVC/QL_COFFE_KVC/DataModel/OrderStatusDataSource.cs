using System.Collections.Generic;

namespace QL_COFFE_KVC
{
    public sealed class OrderStatusDataSource
    {
        public static List<Param> Instance { get; } = new List<Param> { new Param("Lập hóa đơn", "0"), new Param("Chờ thanh toán", "1"), new Param("Đã thanh toán", "2"), new Param("Đã hủy", "3"), new Param("Thành công", "4") };
    }
}

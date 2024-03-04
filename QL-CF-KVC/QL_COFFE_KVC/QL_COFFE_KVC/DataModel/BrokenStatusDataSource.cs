using System.Collections.Generic;

namespace QL_COFFE_KVC
{
    public sealed class BrokenStatusDataSource
    {
        public static List<Param> Instance { get; } = new List<Param> { new Param("Lập phiếu", "0"), new Param("Chờ duyệt", "1"), new Param("Đã duyệt", "2"), new Param("Đã hủy", "3"), new Param("Hoàn thành", "4") };
    }
}

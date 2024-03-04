using System.Collections.Generic;

namespace QL_COFFE_KVC
{
    public sealed class ServiceDataSource
    {
        public static List<Param> Instance { get; } = new List<Param> { new Param("Tất cả", "*"), new Param("Cafe", "0"), new Param("Khu vui chơi", "1"), new Param("Khu đọc sách", "2") };
    }
}

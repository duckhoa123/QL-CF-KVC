using System.Collections.Generic;

namespace QL_COFFE_KVC
{
    public sealed class StatusDataSource
    {
        public static List<Param> Instance { get; } = new List<Param> { new Param("Còn sử dụng", "1"), new Param("Không sử dụng", "0") };
    }
}

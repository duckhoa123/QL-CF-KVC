using System.Collections.Generic;

namespace QL_COFFE_KVC
{
    public sealed class BookStatusDataSource
    {
        public static List<Param> Instance { get; } = new List<Param> { new Param("Còn sách", "1"), new Param("Hết sách", "2") };
    }
}

using System.Collections.Generic;

namespace QL_COFFE_KVC
{
    public sealed class SexDataSource
    {
        public static List<Param> Instance { get; } = new List<Param> { new Param("Nam", "M"), new Param("Nữ", "F"), new Param("Khác", "") };
    }
}

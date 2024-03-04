using System;
using System.Data;

namespace QL_COFFE_KVC
{
    public class DataRowArgs : EventArgs
    {
        public DataRow Value { get; }
        public DataRowArgs(DataRow value)
        {
            Value = value;
        }
    }
}

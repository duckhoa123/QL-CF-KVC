using System;
using System.Data;

namespace QL_COFFE_KVC
{
    public class DataSetArgs : EventArgs
    {
        public DataSet Value { get; }
        public DataSetArgs(DataSet value)
        {
            Value = value;
        }
    }
}

using System;

namespace QL_COFFE_KVC
{
    public class Param
    {
        public string Name { get; }
        public object Value { get; }
        public Type TypeValue { get; }

        public Param(string name, object value)
        {
            Name = name;
            Value = value;
            TypeValue = value?.GetType();
        }

        public Param(string name, object value, Type type)
        {
            Name = name;
            Value = value;
            TypeValue = type;
        }
    }
}

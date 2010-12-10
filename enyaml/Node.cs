using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace enyaml
{
    public class Node
    {
        public Node(object val)
        {
            _value = val;
        }

        private object _value;
        public T GetValue<T>() 
        {
            return (T)_value;
        }
        public object GetValue()
        {
            return _value;
        }
        
        public bool IsScalar
        {
            get
            {
                if (_value == null)
                    return true;
                var t = _value.GetType();
                return t == typeof(string) || t == typeof(int) || t == typeof(double) || t == typeof(DateTime);
            }
        }
        public bool IsSequence
        {
            get { return _value is Sequence; }
        }
        public bool IsMap
        {
            get { return _value is Map; }
        }
    }
}

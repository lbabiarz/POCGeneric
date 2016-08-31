using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    public class DataNode<TKey, TObject, TValue> : IOperations<TKey, TObject, TValue>
    {
        TKey Key;
        List<TObject> ReferenceObject;
        TValue ValueObject;


        public DataNode(TKey key, List<TObject> obj, TValue val)
        {
            Key = key;
            ReferenceObject = obj;
            ValueObject = val;
        }

        public TKey GetKey()
        {
            return Key;
        }

        public TObject GetObject()
        {
            return ReferenceObject.First();
        }

        public TValue GetValue()
        {
            return ValueObject;
        }

        //public void AddNewItem()
        //{
        //    ReferenceObject.
        //}


    }
}

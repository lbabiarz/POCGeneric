using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    public interface IOperations<TKey, TObject, TValue>
    {
        TKey GetKey();
        TObject GetObject();
        TValue GetValue();
    }
}
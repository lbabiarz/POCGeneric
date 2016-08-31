using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TestClass> listOfCl = new List<TestClass>();
            TestClass cl = new TestClass()
            {
                A = 1,
                B = "TEST1",
                C = 1.3
            };

           TestClass cl2 = new TestClass()
            {
                A = 1,
                B = "TEST1",
                C = 1.3
            };
            listOfCl.Add(cl);
            listOfCl.Add(cl2);

            TestStruct str = new TestStruct()
            {
                D = Int32.MaxValue,
                F = "TEST2"
            };


            DataNode<string, List<TestClass>, TestStruct> node = new DataNode<string, List<TestClass>, TestStruct>("test", listOfCl, str);
            Console.WriteLine(node.GetKey());
            Console.Read();

        }
    }
}
